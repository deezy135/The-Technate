#pragma once
#include "building.h"
#include "resource.h"

class ExtractBuilding : public Building {
public:
	static const int MaxOutput = 4;
	virtual void updateLogics();
	virtual void updatePhysics();
	virtual void setOutput(int index, Resource::Type type, float speed, float max);

private:
	int outputs;
	Resource output[MaxOutput];
	float max[MaxOutput];
	float speed[MaxOutput];
};