#pragma once
#include <SDL.h>

class Timer {
public:
	static void sleep(Uint32 ticks);
	static Uint32 getNextTicks(Timer *t1, Timer *t2, Timer *t3);
	static Uint32 getTicks();
	bool init();
	void start();
	void stop();
	void pause();
	void unpause();
	bool isStarted();
	bool isPaused();
	Uint32 getTimerTicks();
	bool isTimeTo(Uint32 currentTicks);
	void update();
	void setPerSecond(Uint32 perSecond);
	Uint32 getNextTicks();
private:
	float nextTicks;
	float timestamp;
	Uint32 startedTicks;
	Uint32 pausedTicks;
	bool paused;
	bool started;
};