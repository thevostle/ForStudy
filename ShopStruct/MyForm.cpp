#include "MyForm.h"
#include "StructList.h"
#include <Windows.h>

using namespace ShopStruct; // Название проекта

int WINAPI WinMain(HINSTANCE, HINSTANCE, LPSTR, int) {
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	Application::Run(gcnew MyForm);

	List<Shop> ShopList;

	return 0;
}

void AddShop(Shop newShop) {
	ShopList.push_back(newShop);
}

System::Void MyForm::Button1_Click(System::Object^ sender, System::EventArgs^ e)
{
	Shop newShop;
	newShop.cost_1 = System::Convert::ToInt32(ShopStruct::MyForm::textBox1->Text);
	newShop.cost_2 = System::Convert::ToInt32(ShopStruct::MyForm::textBox2->Text);
	newShop.cost_3 = System::Convert::ToInt32(ShopStruct::MyForm::textBox3->Text);
	newShop.coords_x = System::Convert::ToInt32(ShopStruct::MyForm::numericUpDown1->Value);
	newShop.coords_y = System::Convert::ToInt32(ShopStruct::MyForm::numericUpDown2->Value);
	AddShop(newShop);
}
