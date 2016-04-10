#include "game.h"

Game::Game() {
	eng = NULL;
	state = NULL;
}

bool Game::init(Engine * engine) {
	eng = engine;
	if (!menu.init(engine)) {
		return false;
	}

	if (!play.init(engine)) {
		menu.close();
		return false;
	}
	state = &play;
	return true;
}

void Game::run() {
	bool running = true;
	while (running) {
		eng->updateInput();

		State::StateEvent se = state->update();
		switch (se) {
		case State::StateEvent::Quit: running = false; break;
		case State::StateEvent::Render: eng->updateGraphics(); break;
		case State::StateEvent::Menu: break;
		}
		//eng->updateGraphics();
	}
}

void Game::close() {
	eng = NULL;
	menu.close();
	play.close();
	state = NULL;
}

Game::~Game() {
}
