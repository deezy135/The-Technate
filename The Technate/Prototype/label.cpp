#include "label.h"
#include "globalobject.h"
#include "graphics.h"

void Label::init(std::string text) {
	rnd = Go::getGraphics()->getRenderer();
	font = Go::getFontManager()->getFont(0);
	color = *Go::getColorManager()->getColor(ColorManager::ColorID(0));
	rect.x = 0, rect.y = 0;
	txt = text;
	hasChanged = true;
}

void Label::init(FontID fontID, ColorManager::ColorID colorID, int x, int y, std::string text) {
	rnd = Go::getGraphics()->getRenderer();
	font = Go::getFontManager()->getFont(fontID);
	color = *Go::getColorManager()->getColor(colorID);
	rect.x = x, rect.y = y;
	txt = text;
	hasChanged = true;
}

void Label::setFont(FontID fontID) {
	font = Go::getFontManager()->getFont(fontID);
	hasChanged = true;
}

void Label::setColor(ColorManager::ColorID colorID) {
	color = *Go::getColorManager()->getColor(colorID);
	hasChanged = true;
}

void Label::setText(std::string text) {
	txt = text;
	hasChanged = true;
}

void Label::append(std::string text) {
	txt.append(text);
	hasChanged = true;
}

void Label::handleInput() {
}

void Label::render() {
	SDL_RenderCopy(rnd, tex, NULL, &rect);
}

void Label::render(int x, int y) {
	rect.x = x, rect.y = y;
	SDL_RenderCopy(rnd, tex, NULL, &rect);
}

void Label::update() {
	if (hasChanged) {
		SDL_Surface *srf = TTF_RenderText_Blended(font, txt.c_str(), color);
		if (tex != NULL) {
			SDL_DestroyTexture(tex);
		}
		tex = SDL_CreateTextureFromSurface(rnd, srf);
		rect.w = srf->w;
		rect.h = srf->h;
		SDL_FreeSurface(srf);
		hasChanged = false;
	}
}

void Label::destroy() {
	SDL_DestroyTexture(tex);
	rect = { 0, 0, 0, 0 };
	txt.clear();
}
