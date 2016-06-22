#include "texture.h"
#include "texturemanager.h"

void Texture::setImage(TextureManager * tm, TexID imgID) {
	tex = tm->getTexture(imgID);
	rnd = tm->getRenderer();
}

void Texture::setSize(int width, int height) {
	rect.w = width;
	rect.h = height;
}

void Texture::setLocation(int x, int y) {
	rect.x = x;
	rect.y = y;
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

void Texture::render() {
	SDL_RenderCopy(rnd, tex, NULL, &rect);
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