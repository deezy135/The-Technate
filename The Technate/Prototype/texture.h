#pragma once
#include <SDL.h>
#include "camera.h"
#include "constants.hpp"

class TextureManager;

class Texture {
public:
	void setImage(TextureManager * tm, TexID imgID);
	void setSize(int width, int height);
	void setLocation(int x, int y);
	
	SDL_Renderer * getRenderer();
	SDL_Texture * getTexture();

	void blit(Texture * texture, SDL_Rect * rect);

	void render();
	void render(int x, int y);
	void render(Camera* camera);

	void create(int w, int h);
	void destroy();
private:
	SDL_Texture * tex;
	SDL_Renderer * rnd;
	SDL_Rect rect;
};