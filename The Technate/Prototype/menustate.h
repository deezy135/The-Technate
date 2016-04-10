#pragma once
#include "state.h"

class MenuState : public State {
public:
	virtual bool init(Engine * engine);
	virtual StateEvent update();
	virtual void close();
private:
	Input * input;
};