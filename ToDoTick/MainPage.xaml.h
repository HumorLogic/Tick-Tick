//
// MainPage.xaml.h
// MainPage 类的声明。
//

#pragma once

#include "MainPage.g.h"
#include<string>


namespace ToDoTick
{
	using namespace Platform;
	using namespace std;
	/// <summary>
	/// 可用于自身或导航至 Frame 内部的空白页。
	/// </summary>
	public ref class MainPage sealed
	{
	
	public:
		MainPage();

	private:
		void startPauseBtn_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e);
		void TickTime(Windows::UI::Xaml::Controls::TextBlock^ timeText);
		String^ time;
		bool isRun;
	};
}
