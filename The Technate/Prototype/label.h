#pragma once
#include "component.h"
#include <SDL_ttf.h>
#include <string>
#include "colormanager.h"

enum FontID;

class Label: public Component {
public:
	void init(std::string text);
	void init(FontID fontID, ColorManager::ColorID colorID, int x, int y, std::string text);
	void setFont(FontID fontID);
	void setColor(ColorManager::ColorID colorID);
	void setText(std::string text);
	void append(std::string text);
	void destroy();

	virtual void handleInput();
	virtual void render();
	virtual void render(int x, int y);
	virtual void update();
private:
	SDL_Color color;
	TTF_Font *font;
	SDL_Renderer *rnd;
	SDL_Texture *tex;
	std::string txt;
	bool hasChanged;
};