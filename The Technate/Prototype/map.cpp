#include "map.h"
#include <random>

bool Map::init(TextureManager * tm) {
	tileW = tileH = 64;
	rows = 25, cols = 25;

	tex.setImage(tm, TexID::Land);
	tex.create(tileW*cols, tileH*rows);
	
	for (int i = 0; i < Tile::Total; i++) {
		tile[i].setImage(tm, TexID(TexID::Land + i));
		tile[i].setSize(tileW, tileH);
	}

	SDL_Rect rect = { 0, 0, tileW, tileH };
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < cols; j++) {
			//field[i][j] = Tile(rand() % Tile::Total);
			field[i][j] = Tile::Land;
			rect.x = j*tileW, rect.y = i*tileH;
			tex.blit(&tile[field[i][j]], &rect);
		}
	}
	return true;
}

void Map::update() {
	static int ii = 0;
	static int type = Tile::Water;
	SDL_Rect rect = { ii%cols*tileW, ii/cols*tileH, tileW, tileH };
	//tex.blit(&water, &rect);
	/*if (rand() % 10 == 0) {
		int i = rand() % rows, j = rand() % cols;
		SDL_Rect rect = { j*tileW, i*tileH, tileW, tileH };
		field[i][j] = Tile(rand() % Tile::Total);
		*/
	tex.blit(&tile[type], &rect);
	ii++;
	if (ii >= cols*rows) ii = 0, type = Tile((type + 1) % Tile::Total);
}

void Map::placeBuilding(Texture * buildingTex, int tx, int ty) {
	SDL_Rect rect = { tx*tileW, ty*tileH, tileW, tileH };
	tex.blit(buildingTex, &rect);
}

void Map::render(Camera * camera) {
	tex.render(camera);
}

void Map::close() {
	tex.destroy();
}
