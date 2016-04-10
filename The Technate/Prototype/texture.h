#pragma once
#include <SDL.h>
#include "camera.h"

class Texture {
public:
	void setRect(SDL_Rect * rect);
	void setRenderer(SDL_Renderer * renderer);
	void setTexture(SDL_Texture * texture);

	SDL_Rect * getRect();
	SDL_Renderer * getRenderer();
	SDL_Texture * getTexture();

	void blit(Texture * texture, SDL_Rect * rect);

	void resetRect();
	void resetRenderer();
	void resetTexture();

	void render(int x, int y);
	void render(Camera* camera);

	void create(int w, int h);
	void destroy();
private:
	SDL_Texture * tex;
	SDL_Renderer * rnd;
	SDL_Rect rect;
};