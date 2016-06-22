#pragma once
#include <SDL.h>


class ColorManager {
public:
	enum ColorID { Black, Black1, White, 
		Transparent, Translucent, Blue,
		Total };
	bool init();
	SDL_Color * getColor(ColorID colorID);
private:
	SDL_Color color[ColorID::Total];
};