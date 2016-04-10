#pragma once
#include <SDL.h>
#include "constants.hpp"

class TextureManager {
public:
	TextureManager();
	~TextureManager();
	void setRenderer(SDL_Renderer *rnd);
	SDL_Renderer * getRenderer();
	bool loadTextures();
	bool loadTexture(const char *filename);
	void freeTextures();
	void freeTexture();
	SDL_Texture* getTexture(int i);
private:
	Uint32 textures;
	SDL_Renderer* rnd;
	SDL_Texture* texture[MaxTextures];
	SDL_Surface* surface[MaxTextures];
};