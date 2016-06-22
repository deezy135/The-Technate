#pragma once

class Graphics;
class TextureManager;
class FontManager;
class ColorManager;
class Input;

class Go {
public:
	static Graphics * getGraphics();
	static TextureManager * getTextureManager();
	static FontManager * getFontManager();
	static ColorManager * getColorManager();
	static Input * getInput();
	static void setGraphics(Graphics *);
	static void setTextureManager(TextureManager *);
	static void setFontManager(FontManager *);
	static void setColorManager(ColorManager *);
	static void setInput(Input *);
private:
	static Graphics * gr;
	static TextureManager * tm;
	static FontManager * fm;
	static ColorManager * cm;
	static Input * in;
};