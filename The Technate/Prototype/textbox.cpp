#include "textbox.h"
#include "globalobject.h"
#include "graphics.h"
#include "fontmanager.h"
#include "input.h"

void Textbox::init(int w, int h, std::string text) {
	rnd = Go::getGraphics()->getRenderer();
	font = Go::getFontManager()->getFont(0);
	textColor = *Go::getColorManager()->getColor(ColorManager::ColorID::Black);
	bgColor = *Go::getColorManager()->getColor(ColorManager::ColorID::Transparent);
	rect.x = 0, rect.y = 0, rect.w = w, rect.h = h;
	txt = text;
	hasChanged = true;
	state = State::Unselected;
}

void Textbox::init(FontID fontID, ColorManager::ColorID textColorID, ColorManager::ColorID bgColorID, int x, int y, int w, int h, std::string text) {
	rnd = Go::getGraphics()->getRenderer();
	font = Go::getFontManager()->getFont(fontID);
	textColor = *Go::getColorManager()->getColor(textColorID);
	bgColor = *Go::getColorManager()->getColor(bgColorID);
	rect.x = x, rect.y = y, rect.w = w, rect.h = h;
	txt = text;
	hasChanged = true;
	state = State::Unselected;
}

void Textbox::setFont(FontID fontID) {
	font = Go::getFontManager()->getFont(fontID);
	hasChanged = true;
}

void Textbox::setTextColor(ColorManager::ColorID textColorID) {
	textColor = *Go::getColorManager()->getColor(textColorID);
	hasChanged = true;
}

void Textbox::setBgColor(ColorManager::ColorID bgColorID) {
	bgColor = *Go::getColorManager()->getColor(bgColorID);
	hasChanged = true;
}

void Textbox::setSize(int w, int h) {
	rect.w = w, rect.h = h;
}

void Textbox::setText(std::string text) {
	txt = text;
	hasChanged = true;
}

void Textbox::destroy() {
}

void Textbox::handleInput() {
	Input* in = Go::getInput();
	int mx = in->getMX(), my = in->getMY();
	if (rect.x <= mx && mx <= rect.x + rect.w &&
		rect.y <= my && my <= rect.y + rect.h) {
		if (in->getMbLeft()) {
			if (state != State::Selected) {
				hasChanged = true;
			}
			state = State::Selected;
		}
	}
	else {
		if (in->getMbLeft()) {
			if (state != State::Unselected) {
				hasChanged = true;
			}
			state = State::Unselected;
		}
	}
}

void Textbox::render() {
	SDL_RenderCopy(rnd, tex, NULL, &rect);
}

void Textbox::render(int x, int y) {
	rect.x = x, rect.y = y;
	SDL_RenderCopy(rnd, tex, NULL, &rect);
}

void Textbox::update() {
	if (hasChanged) {
		SDL_Color textColorTmp, bgColorTmp;
		switch (state) {
		case State::Unselected:
			textColorTmp = textColor;
			bgColorTmp = bgColor;
			break;
		case State::Selected:
			textColorTmp = { Uint8(8 * textColor.r / 10), Uint8(8 * textColor.g / 10), Uint8(8 * textColor.b / 10), textColor.a };
			bgColorTmp = { Uint8(8 * bgColor.r / 10), Uint8(8 * bgColor.g / 10), Uint8(8 * bgColor.b / 10),  bgColor.a };
			break;
		}
		SDL_Surface *srf = TTF_RenderText_Blended(font, txt.c_str(), textColorTmp);
		SDL_Rect srfRect = { 0, 0, srf->w, srf->h };
		if (tex != NULL) {
			SDL_DestroyTexture(tex);
		}
		SDL_PixelFormat *f = srf->format;
		SDL_Surface *bg = SDL_CreateRGBSurface(0, rect.w, rect.h, f->BitsPerPixel,
			f->Rmask, f->Gmask, f->Bmask, f->Amask);
		SDL_FillRect(bg, NULL, SDL_MapRGBA(f, bgColorTmp.r, bgColorTmp.g, bgColorTmp.b, bgColorTmp.a));
		SDL_BlitSurface(srf, NULL, bg, &srfRect);
		tex = SDL_CreateTextureFromSurface(rnd, bg);
		SDL_FreeSurface(bg);
		SDL_FreeSurface(srf);
		hasChanged = false;
	}
}
