#pragma once
#include "building.h"
#include "resource.h"

class ProcessBuilding : public Building {
public:
	static const int MaxInput = 4;
	static const int MaxOutput = 4;
	virtual void updateLogics();
	virtual void updatePhysics();
private:
	int inputs;
	int outputs;
	Resource input[MaxInput];
	Resource output[MaxInput];
};