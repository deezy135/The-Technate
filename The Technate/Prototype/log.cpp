#include "log.h"
#include <iostream>
#include "variables.h"

void Log::showError(const char * msg, const char * value) {
	std::cout << msg;
	if (value != NULL) {
		std::cout << ": " << value;
	}
	std::cout << std::endl;
}
