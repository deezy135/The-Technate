#include "label.h"

void Label::init(SDL_Renderer *rnd, TTF_Font * font, SDL_Color color, int x, int y, const char * text) {
	setRenderer(rnd);
	setFont(font);
	setColor(color);
	setPosition(x, y);
	setText(text);
}

void Label::setRenderer(SDL_Renderer * rnd) {
	this->rnd = rnd;
}

void Label::setFont(TTF_Font * font) {
	this->font = font;
}

void Label::setColor(SDL_Color color) {
	this->color = color;
}

void Label::setPosition(int x, int y) {
	rect.x = x, rect.y = y;
}

void Label::setText(const char * text) {
	this->text = text;
	create();
}

void Label::append(const char * text) {
	std::string s = this->text;
	this->text.append(text);
	create();
	this->text = s;
}

void Label::render() {
	SDL_RenderCopy(rnd, tex, NULL, &rect);
}

void Label::render(int x, int y) {
	rect.x = x, rect.y = y;
	SDL_RenderCopy(rnd, tex, NULL, &rect);
}

void Label::create() {
	SDL_Surface *srf = TTF_RenderText_Solid(font, text.c_str(), color);
	if (tex != NULL) {
		SDL_DestroyTexture(tex);
	}
	tex = SDL_CreateTextureFromSurface(rnd, srf);
	rect.w = srf->w;
	rect.h = srf->h;
	SDL_FreeSurface(srf);
}

void Label::destroy() {
	SDL_DestroyTexture(tex);
	rect = { 0, 0, 0, 0 };
	text.clear();
}
