#include "fontmanager.h"
#include <fstream>
#include "variables.h"
#include "log.h"

void FontManager::setRenderer(SDL_Renderer * rnd) {
	this->rnd = rnd;
}

bool FontManager::loadFonts() {
	std::ifstream fin;
	fin.open(FontsInfoFile);
	if (!fin.is_open()) {
		Log::showError(ErrorMsg::FileNotFound, FontsInfoFile);
		return false;
	}
	try {
		std::string dir;
		std::getline(fin, dir);
		while (!fin.eof()) {
			std::string line;
			std::getline(fin, line);
			if (!loadFont(line.insert(0, dir).c_str())) {
				throw 1;
			}
		}
	}
	catch (...) {
		fin.close();
		freeFonts();
		return false;
	}

	fin.close();
	return true;
}

bool FontManager::loadFont(const char * filename) {
	font[fonts] = TTF_OpenFont(filename, 18);
	if (font[fonts] == NULL) {
		Log::showError(TTF_GetError());
		return false;
	}
	fonts++;
	return true;
}

void FontManager::freeFonts() {
	for (Uint32 i = 0; i < fonts; i++) {
		TTF_CloseFont(font[i]);
	}
	fonts = 0;
}

void FontManager::freeFont() {
}

TTF_Font * FontManager::getFont(int i) {
	return font[i];
}
