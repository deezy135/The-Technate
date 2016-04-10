#include "timer.h"

void Timer::sleep(Uint32 ticks) {
	SDL_Delay(ticks);
}

Uint32 Timer::getNextTicks(Timer * t1, Timer * t2, Timer * t3) {
	Uint32 nextTicks = SDL_GetTicks() + 1000;
	Uint32 nextTicks1 = t1->getNextTicks();
	Uint32 nextTicks2 = t2->getNextTicks();
	Uint32 nextTicks3 = t3->getNextTicks();
	if (!t1->isPaused() && nextTicks1 < nextTicks) {
		nextTicks = nextTicks1;
	}
	if (!t2->isPaused() && nextTicks2 < nextTicks) {
		nextTicks = nextTicks2;
	}
	if (!t3->isPaused() && nextTicks3 < nextTicks) {
		nextTicks = nextTicks3;
	}
	return nextTicks;
}

Uint32 Timer::getTicks() {
	return SDL_GetTicks();
}

bool Timer::init() {
	startedTicks = 0;
	pausedTicks = 0;
	paused = false;
	started = false;
	timestamp = 0;
	nextTicks = 0;
	return true;
}

void Timer::start() {
	startedTicks = SDL_GetTicks();
	pausedTicks = 0;
	started = true;
	paused = false;
}

void Timer::stop() {
	startedTicks = 0;
	pausedTicks = 0;
	started = false;
	paused = false;
}

void Timer::pause() {
	if (started && !paused) {
		pausedTicks = SDL_GetTicks() - startedTicks;
		paused = true;
		//startedTicks = 0;
	}
}

void Timer::unpause() {
	if (started && paused) {
		Uint32 cur = SDL_GetTicks();
		nextTicks += cur - pausedTicks - startedTicks;
		startedTicks = cur - pausedTicks;
		pausedTicks = 0;
		paused = false;
	}
}

Uint32 Timer::getTimerTicks() {
	Uint32 ticks = 0;
	if (started) {
		if (paused) {
			ticks = pausedTicks;
		}
		else {
			ticks = SDL_GetTicks() - startedTicks;
		}
	}
	return ticks;
}

bool Timer::isStarted() {
	return started;
}

bool Timer::isPaused() {
	return paused;
}

bool Timer::isTimeTo(Uint32 currentTicks) {
	return !paused && currentTicks >= nextTicks;
}

void Timer::update() {
	nextTicks += timestamp;
}

void Timer::setPerSecond(Uint32 perSecond) {
	timestamp = 1000.f / perSecond;
}

Uint32 Timer::getNextTicks() {
	return Uint32(nextTicks);
}
