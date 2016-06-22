#include "resourcemanager.h"

bool ResourceManager::init(TextureManager * tm) {
	for (int i = 0; i < Resource::Type::Total; i++) {
		tex[i].setImage(tm, TexID(TexID::ResWood + i));
		tex[i].setSize(20, 20);
	}
	return true;
}

void ResourceManager::render(Resource::Type type, int x, int y) {
	tex[type].render(x, y);
}

void ResourceManager::render(Resource::Type type, Camera * cam, int mx, int my) {
	int x, y, w, h;
	int cx = cam->getRect()->x, cy = cam->getRect()->y;
	int cw = cam->getRect()->w, ch = cam->getRect()->h;
	w = 64 * 640 / cw;
	h = 64 * 480 / ch;
	x = ((cx + mx*cw / 640) / 64 * 64 - cx) * 640 / cw;
	y = ((cy + my*ch / 480) / 64 * 64 - cy) * 480 / ch;
	tex[type].setSize(w, h);
	tex[type].setLocation(x, y);
	tex[type].render();
}

void ResourceManager::close() {
	/*for (int i = 0; i < Resource::Type::Total; i++) {
		tex[i].destroy();
	}*/
}
