#include "menustate.h"

bool MenuState::init(Engine * engine) {
	this->input = input;
	return true;
}

State::StateEvent MenuState::update() {
	if (input->getQuit()) {
		return StateEvent::Quit;
	}
	return StateEvent::Run;
}

void MenuState::close() {
	input = NULL;
}
