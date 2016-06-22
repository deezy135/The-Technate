#pragma once
#include "building.h"

class AdminBuilding : public Building {
public:
	//virtual void render(int x, int y);
	virtual void updateLogics();
	virtual void updatePhysics();
private:
	
};