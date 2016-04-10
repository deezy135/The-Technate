#pragma once
#include <string>
#include "constants.hpp"
#include "variables.h"

class Log {
public:
	static void showError(const char * msg, const char * value = NULL);
};