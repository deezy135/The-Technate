#include "extractbuilding.h"
#include "player.h"

void ExtractBuilding::updateLogics() {
	for (int i = 0; i < outputs; i++) {
		output[i].addQuantity(speed[i]);
		if (output[i].getQuantity() > max[i]) {
			output[i].addQuantity(-max[i]);
			player->addResource(output[i].getType(), max[i]);
		}
	}
}

void ExtractBuilding::updatePhysics() {

}

void ExtractBuilding::setOutput(int index, Resource::Type type, float speed, float max) {
	output[index].setType(type);
	this->max[index] = max;
	this->speed[index] = speed;
	outputs = index + 1;
	//output[index].setMax(max);
	//output[index].setSpeed(speed);
}
