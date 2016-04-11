#include "map.h"
#include <random>

bool Map::init(TextureManager * tm) {
	tileW = tileH = 64;
	rows = 25, cols = 25;

	tex.setRenderer(tm->getRenderer());
	tex.create(tileW*cols, tileH*rows);
	bg.setTexture(tm->getTexture(TexID::MapBG));
	land.setTexture(tm->getTexture(TexID::Land));
	water.setTexture(tm->getTexture(TexID::Water));
	hill.setTexture(tm->getTexture(TexID::Hill));

	bg.setRenderer(tm->getRenderer());
	land.setRenderer(tm->getRenderer());
	water.setRenderer(tm->getRenderer());
	hill.setRenderer(tm->getRenderer());

	
	SDL_Rect rect = { 0, 0, 400, 400 };
	bg.setRect(&rect);

	tex.blit(&bg, &rect);
	rect = { 0, 0, tileW, tileH };
	land.setRect(&rect);
	water.setRect(&rect);
	hill.setRect(&rect);

	rect.w = tileW, rect.h = tileH;
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < cols; j++) {
			//field[i][j] = Tile(rand() % Tile::Total);
			field[i][j] = Tile::Land;
			rect.x = j*tileW, rect.y = i*tileH;
			switch (field[i][j]) {
			case Tile::Land: tex.blit(&land, &rect); break;
			case Tile::Water: tex.blit(&water, &rect); break;
			case Tile::Hill: tex.blit(&hill, &rect); break;
			}
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
	switch (type) {
	case Tile::Land: tex.blit(&land, &rect); break;
	case Tile::Water: tex.blit(&water, &rect); break;
	case Tile::Hill: tex.blit(&hill, &rect); break;
	}
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
