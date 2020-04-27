#pragma once

namespace ToDoTick {

	class Stopwatch {
	public:
		Stopwatch();
		bool isRun;
		void GetTime(Windows::UI::Xaml::Controls::TextBlock^ textBlock);

	private:
		void Start();
		void Pause();

	};
}