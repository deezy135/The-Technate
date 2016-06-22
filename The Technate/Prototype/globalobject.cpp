#include "globalobject.h"

Graphics * Go::gr = nullptr;
TextureManager * Go::tm = nullptr;
FontManager * Go::fm = nullptr;
ColorManager * Go::cm = nullptr;
Input * Go::in = nullptr;

Graphics * Go::getGraphics() {
	return gr;
}

TextureManager * Go::getTextureManager() {
	return tm;
}

FontManager * Go::getFontManager() {
	return fm;
}

ColorManager * Go::getColorManager() {
	return cm;
}

Input * Go::getInput() {
	return in;
}

void Go::setGraphics(Graphics * graphics) {
	gr = graphics;
}

void Go::setTextureManager(TextureManager * textureManager) {
	tm = textureManager;
}

void Go::setFontManager(FontManager * fontManager) {
	fm = fontManager;
}

void Go::setColorManager(ColorManager *colorManager) {
	cm = colorManager;
}

void Go::setInput(Input * input) {
	in = input;
}
