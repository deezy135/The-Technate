#pragma once
#include "resource.h"
#include "texture.h"
#include "camera.h"
#include "texturemanager.h"

class ResourceManager {
public:
	bool init(TextureManager * tm);
	void render(Resource::Type type, int x, int y);
	void render(Resource::Type type, Camera* cam, int mx, int my);

	void close();
private:
	Texture tex[Resource::Type::Total];
	std::string name[Resource::Type::Total];
};