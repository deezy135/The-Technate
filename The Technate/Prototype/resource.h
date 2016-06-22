#pragma once
#include <string>
#include "texture.h"

class Resource {
public:
	enum Type { Wood, Iron, Steel, Total };
	void setType(Type type);
	void setMax(float max);
	void setSpeed(float speed);
	void setQuantity(float quantity);
	void addQuantity(float quantity);
	Type getType();
	float getMax();
	float getQuantity();
private:
	Type type;
	float max;
	float speed;
	float quantity;
};