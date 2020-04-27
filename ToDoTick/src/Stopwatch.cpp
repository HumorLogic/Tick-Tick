#include"Stopwatch.h"

namespace ToDoTick {

	Stopwatch::Stopwatch():isRun(false)
	{
	}

	void Stopwatch::GetTime(Windows::UI::Xaml::Controls::TextBlock^ textBlock)
	{
	}

	void Stopwatch::Start() {
		isRun = true;
	}

	void Stopwatch::Pause() {
		isRun = false;
	}
}


