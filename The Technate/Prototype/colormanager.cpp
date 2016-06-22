#include "colormanager.h"

bool ColorManager::init() {
	color[ColorID::Black] = { 0, 0, 0, 255 };
	color[ColorID::Black1] = { 13, 13, 13, 255 };
	color[ColorID::White] = { 255, 255, 255, 255 };
	color[ColorID::Transparent] = { 0, 0, 0, 0 };
	color[ColorID::Translucent] = { 0, 0, 0, 127 };
	color[ColorID::Blue] = { 0, 0, 255, 255 };
	return true;
}

SDL_Color * ColorManager::getColor(ColorID colorID) {
	return &color[colorID];
}
