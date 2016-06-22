#include "button.h"
#include "globalobject.h"
#include "fontmanager.h"
#include "graphics.h"
#include "input.h"

void Button::init(std::string text) {
	rnd = Go::getGraphics()->getRenderer();
	font = Go::getFontManager()->getFont(0);
	textColor = *Go::getColorManager()->getColor(ColorManager::ColorID::Black);
	bgColor = *Go::getColorManager()->getColor(ColorManager::ColorID::Transparent);
	rect.x = 0, rect.y = 0;
	txt = text;
	hasChanged = true;
	state = State::Released;
}

void Button::init(FontID fontID, ColorManager::ColorID textColorID, ColorManager::ColorID bgColorID, int x, int y, std::string text) {
	rnd = Go::getGraphics()->getRenderer();
	font = Go::getFontManager()->getFont(fontID);
	textColor = *Go::getColorManager()->getColor(textColorID);
	bgColor = *Go::getColorManager()->getColor(bgColorID);
	rect.x = x, rect.y = y;
	txt = text;
	hasChanged = true;
	state = State::Released;
}

void Button::setFont(FontID fontID) {
	font = Go::getFontManager()->getFont(fontID);
	hasChanged = true;
}

void Button::setTextColor(ColorManager::ColorID textColorID) {
	textColor = *Go::getColorManager()->getColor(textColorID);
	hasChanged = true;
}

void Button::setBgColor(ColorManager::ColorID bgColorID) {
	bgColor = *Go::getColorManager()->getColor(bgColorID);
	hasChanged = true;
}

void Button::setText(std::string text) {
	txt = text;
	hasChanged = true;
}

void Button::handleInput() {
	Input* in = Go::getInput();
	int mx = in->getMX(), my = in->getMY();
	if (rect.x <= mx && mx <= rect.x + rect.w &&
		rect.y <= my && my <= rect.y + rect.h) {
		if (in->getMbLeft()) {
			if (state != State::Pressed) {
				hasChanged = true;
			}
			state = State::Pressed;
		}
		else {
			if (state != State::Hovered) {
				hasChanged = true;
			}
			if (state == State::Pressed) {

			}
			state = State::Hovered;
		}
	}
	else {
		if (state != State::Released) {
			hasChanged = true;
		}
		state = State::Released;
	}
}

void Button::render() {
	SDL_RenderCopy(rnd, tex, NULL, &rect);
}

void Button::render(int x, int y) {
	rect.x = x, rect.y = y;
	SDL_RenderCopy(rnd, tex, NULL, &rect);
}

void Button::update() {
	if (hasChanged) {
		SDL_Color textColorTmp, bgColorTmp;
		switch (state) {
		case State::Released:
			textColorTmp = textColor;
			bgColorTmp = bgColor;
			break;
		case State::Hovered:
			textColorTmp = { Uint8(8 * textColor.r / 10), Uint8(8 * textColor.g / 10), Uint8(8 * textColor.b / 10), textColor.a };
			bgColorTmp = { Uint8(8 * bgColor.r / 10), Uint8(8 * bgColor.g / 10), Uint8(8 * bgColor.b / 10),  bgColor.a };
			break;
		case State::Pressed:
			textColorTmp = { Uint8(6 * textColor.r / 10), Uint8(6 * textColor.g / 10), Uint8(6 * textColor.b / 10), textColor.a };
			bgColorTmp = { Uint8(6 * bgColor.r / 10), Uint8(6 * bgColor.r / 10), Uint8(6 * bgColor.r / 10), bgColor.a };
			break;
		}
		SDL_Surface *srf = TTF_RenderText_Blended(font, txt.c_str(), textColorTmp);
		if (tex != NULL) {
			SDL_DestroyTexture(tex);
		}
		SDL_PixelFormat *f = srf->format;
		SDL_Surface *bg = SDL_CreateRGBSurface(0, srf->w, srf->h, f->BitsPerPixel,
			f->Rmask, f->Gmask, f->Bmask, f->Amask);
		SDL_FillRect(bg, NULL, SDL_MapRGBA(f, bgColorTmp.r, bgColorTmp.g, bgColorTmp.b, bgColorTmp.a));
		SDL_BlitSurface(srf, NULL, bg, NULL);
		tex = SDL_CreateTextureFromSurface(rnd, bg);
		rect.w = srf->w;
		rect.h = srf->h;
		SDL_FreeSurface(bg);
		SDL_FreeSurface(srf);
		hasChanged = false;
	}
}

void Button::destroy() {
	SDL_DestroyTexture(tex);
	rect = { 0, 0, 0, 0 };
	txt.clear();
}
