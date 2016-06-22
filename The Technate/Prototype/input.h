#pragma once
#include <SDL.h>

// Создать очередь событий с внешних устройств

class Input {
public:
	Input();
	~Input();
	bool init();
	void update();
	void close();

	bool getQuit();
	bool getArrowUp();
	bool getArrowDown();
	bool getArrowLeft();
	bool getArrowRight();
	bool getW();
	bool getA();
	bool getS();
	bool getD();
	bool getF5();
	bool getEnter();
	bool getMbLeft();
	bool getMbRight();
	bool getMbMiddle();
	int getMX();
	int getMY();
	int getMwY();
	bool getKey1();
	bool getKey2();
	bool getKey3();
	bool getKey4();
	bool getKey5();
	bool getKey6();
	bool getKey7();
	bool getKey8();
	bool getKey9();
	bool getKey0();
	void clear();
private:
	SDL_Event ev;
	bool quit;
	bool enter;
	bool f5;
	bool arrowUp;
	bool arrowDown;
	bool arrowLeft;
	bool arrowRight;
	bool w;
	bool a;
	bool s;
	bool d;
	bool mbLeft;
	bool mbRight;
	bool mbMiddle;
	int mwY;
	int mx, my;
	bool key1;
	bool key2;
	bool key3;
	bool key4;
	bool key5;
	bool key6;
	bool key7;
	bool key8;
	bool key9;
	bool key0;
};