#include "playstate.h"

bool PlayState::init(Engine * engine) {
	this->input = engine->getInput();
	
	if (!player.init(engine, &bm, &map)) {
		return false;
	}
	if (!map.init(engine->getGraphics()->getTextureManager())) {
		player.close();
		return false;
	}
	if (!bm.init(engine->getGraphics()->getTextureManager())) {
		player.close();
		map.close();
		return false;
	}
	return true;
}

State::StateEvent PlayState::update() {
	map.update();
	player.update();
	if (input->getQuit()) {
		return State::StateEvent::Quit;
	}

	map.render(player.getCamera());
	player.render();
	return State::StateEvent::Run;
}

void PlayState::close() {
	player.close();
}
