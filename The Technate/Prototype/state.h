#pragma once
#include "engine.h"

class State {
public:
	enum StateEvent {
		Quit,
		Run,
		Menu,
		Play,
	};
	virtual bool init(Engine * engine) = 0;
	virtual StateEvent update() = 0;
	virtual void close() = 0;
private:

};