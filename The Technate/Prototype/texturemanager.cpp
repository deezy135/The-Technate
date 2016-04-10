#include "texturemanager.h"
#include "variables.h"
#include "constants.hpp"
#include "log.h"
#include <fstream>
#include <SDL_image.h>

TextureManager::TextureManager() {
	textures = 0;
	for (int i = 0; i < MaxTextures; i++) {
		texture[i] = NULL;
		surface[i] = NULL;
	}
}

bool TextureManager::loadTextures() {
	std::ifstream fin;
	fin.open(TexturesInfoFile);
	if (!fin.is_open()) {
		Log::showError(ErrorMsg::FileNotFound, TexturesInfoFile);
		return false;
	}
	try {
		std::string dir;
		std::getline(fin, dir);
		while (!fin.eof()) {
			std::string line;
			std::getline(fin, line);
			if (!loadTexture(line.insert(0, dir).c_str())) {
				throw 1;
			}
		}
	}
	catch (...) {
		fin.close();
		freeTextures();
		return false;
	}

	fin.close();
	return true;
}

bool TextureManager::loadTexture(const char * filename) {
	surface[textures] = IMG_Load(filename);
	if (surface[textures] == NULL) {
		Log::showError(SDL_GetError());
		return false;
	}
	texture[textures] = SDL_CreateTextureFromSurface(rnd, surface[textures]);
	if (texture[textures] == NULL) {
		Log::showError(SDL_GetError());
		SDL_FreeSurface(surface[textures]);
		return false;
	}
	textures++;
	return true;
}

void TextureManager::freeTextures() {
	for (Uint32 i = 0; i < textures; i++) {
		SDL_DestroyTexture(texture[i]);
		SDL_FreeSurface(surface[i]);
	}
	textures = 0;
}

void TextureManager::freeTexture() {

}

SDL_Texture * TextureManager::getTexture(int i) {
	return texture[i];
}

TextureManager::~TextureManager() {
	textures = 0;
	for (int i = 0; i < MaxTextures; i++) {
		texture[i] = NULL;
		surface[i] = NULL;
	}
}

void TextureManager::setRenderer(SDL_Renderer * rnd) {
	this->rnd = rnd;
}

SDL_Renderer * TextureManager::getRenderer() {
	return rnd;
}
