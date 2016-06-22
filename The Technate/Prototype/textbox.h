#pragma once
#include "component.h"
#include <SDL_ttf.h>
#include <string>
#include "colormanager.h"

enum FontID;

class Textbox : public Component {
public:
	enum State { Unselected, Selected };
	void init(int w, int h, std::string text);
	void init(FontID fontID, ColorManager::ColorID textColorID,
		ColorManager::ColorID bgColorID,
		int x, int y, int w, int h, std::string text);
	void setFont(FontID fontID);
	void setTextColor(ColorManager::ColorID textColorID);
	void setBgColor(ColorManager::ColorID bgColorID);
	void setSize(int w, int h);
	void setText(std::string text);
	void destroy();

	virtual void handleInput();
	virtual void render();
	virtual void render(int x, int y);
	virtual void update();
private:
	TTF_Font *font;
	SDL_Color textColor;
	SDL_Color bgColor;
	SDL_Renderer *rnd;
	SDL_Texture *tex;
	std::string txt;
	bool hasChanged;
	State state;
};