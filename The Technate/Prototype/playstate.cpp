#include "playstate.h"
#include "globalobject.h"
#include <iostream>
#include <algorithm>
#include "colormanager.h"

bool PlayState::init(Engine * engine) {
	input = Go::getInput();
	logicPerSecond = 20;
	physicsPerSecond = 60;
	graphicsPerSecond = 60;
	if (!player.init(engine, &bm, &rm, &map)) {
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
	SDL_Color color = { 13, 13, 13, 255 };
	logicTimer.init();
	physicsTimer.init();
	graphicsTimer.init();

	logicTimer.start();
	physicsTimer.start();
	graphicsTimer.start();

	logicTimer.setPerSecond(logicPerSecond);
	physicsTimer.setPerSecond(physicsPerSecond);
	graphicsTimer.setPerSecond(graphicsPerSecond);

	logicTimer.update();
	physicsTimer.update();
	graphicsTimer.update();

	rm.init(Go::getTextureManager());
	fps.init(FontID::Roboto, ColorManager::ColorID::Black, 10, 10, "fps: ");

	player.setMoney(2000);

	return true;
}

State::StateEvent PlayState::update() {
	State::StateEvent e = State::StateEvent::Run;
	static int countedFrames = 0;
	Uint32 currentTicks = Timer::getTicks();
	if (input->getQuit()) {
		return State::StateEvent::Quit;
	}
	if (input->getKey8()) {
		if (logicTimer.isPaused()) {
			logicTimer.unpause();
		}
		else {
			logicTimer.pause();
		}
	}
	if (input->getKey9()) {
		logicPerSecond /= 2;
		if (logicPerSecond < 5) {
			logicPerSecond = 5;
		}
		std::cout << "lps: " << logicPerSecond << std::endl;
		logicTimer.setPerSecond(logicPerSecond);
	}
	if (input->getKey0()) {
		logicPerSecond *= 2;
		if (logicPerSecond > 80) {
			logicPerSecond = 80;
		}
		std::cout << "lps: " << logicPerSecond << std::endl;
		logicTimer.setPerSecond(logicPerSecond);
	}
	if (logicTimer.isTimeTo(currentTicks)) {
		map.update();
		player.updateLogics();
		logicTimer.update();
	}
	if (physicsTimer.isTimeTo(currentTicks)) {
		player.update();
		physicsTimer.update();
	}
	if (graphicsTimer.isTimeTo(currentTicks)) {
		countedFrames++;
		map.render(player.getCamera());
		player.render();
		fps.append(std::to_string(countedFrames / (currentTicks / 1000.0)).c_str());
		fps.render();
		graphicsTimer.update();
		e = State::StateEvent::Render;
	}
	Uint32 nextTicks = Timer::getNextTicks(&logicTimer, 
		&physicsTimer, &graphicsTimer);
	if (currentTicks < nextTicks) {
		Timer::sleep(nextTicks - currentTicks);
	}
	return e;
}

void PlayState::close() {
	rm.close();
	player.close();
}
