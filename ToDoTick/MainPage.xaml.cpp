//
// MainPage.xaml.cpp
// MainPage 类的实现。
//

#include "pch.h"
#include "MainPage.xaml.h"
#include<chrono>
#include<thread>

using namespace ToDoTick;

using namespace Platform;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Controls::Primitives;
using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Input;
using namespace Windows::UI::Xaml::Media;
using namespace Windows::UI::Xaml::Navigation;


// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

MainPage::MainPage()
{
	InitializeComponent();
	
}


void ToDoTick::MainPage::startPauseBtn_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
	//TickTime();
	//timeText->Text =time;
	TickTime(timeText);
}

void MainPage::TickTime(TextBlock^ timeText)
{

	auto start =chrono::system_clock::now();
	this_thread::sleep_for(chrono::seconds(3));
	auto end = chrono::system_clock::now();
	chrono::duration<double> elapsed = end - start;
	time = elapsed.count().ToString();
	timeText->Text = time;
	//throw ref new Platform::NotImplementedException();
}
