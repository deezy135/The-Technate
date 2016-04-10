#include "engine.h"
#include "game.h"

int main(int argc, char** argv) {
	Engine engine;
	Game game;
	if (engine.init()) {
		if (game.init(&engine)) {
			game.run();
			game.close();
		}
		engine.close();
	}
	return 0;
}