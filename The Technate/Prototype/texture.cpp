#include "texture.h"

void Texture::setRect(SDL_Rect * rect) {
	this->rect.x = rect->x;
	this->rect.y = rect->y;
	this->rect.w = rect->w;
	this->rect.h = rect->h;
}

void Texture::setRenderer(SDL_Renderer * renderer) {
	rnd = renderer;
}

void Texture::setTexture(SDL_Texture * texture) {
	tex = texture;
}

SDL_Rect * Texture::getRect() {
	return &rect;
}

SDL_Renderer * Texture::getRenderer() {
	return rnd;
}

SDL_Texture * Texture::getTexture() {
	return tex;
}

void Texture::blit(Texture * texture, SDL_Rect * rect) {
	SDL_SetRenderTarget(rnd, tex);
	SDL_RenderCopy(rnd, texture->getTexture(), NULL, rect);
	SDL_SetRenderTarget(rnd, NULL);
}

void Texture::resetRect() {
	rect.x = rect.y = rect.w = rect.h = 0;
}

void Texture::resetRenderer() {
	rnd = NULL;
}

void Texture::resetTexture() {
	tex = NULL;
}

void Texture::render(int x, int y) {
	rect.x = x, rect.y = y;
	SDL_RenderCopy(rnd, tex, NULL, &rect);
}

void Texture::render(Camera * camera) {
	SDL_RenderCopy(rnd, tex, camera->getRect(), NULL);
}


void Texture::create(int w, int h) {
	tex = SDL_CreateTexture(rnd, SDL_PIXELFORMAT_RGBA8888, SDL_TEXTUREACCESS_TARGET, w, h);
	rect.x = 0, rect.y = 0, rect.w = w, rect.h = h;
}

void Texture::destroy() {
	SDL_DestroyTexture(tex);
	rect = { 0, 0, 0, 0 };
}