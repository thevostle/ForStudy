#include <iostream>
#include <fstream>
#include <sstream>
#include <string>
#include <vector>
#include <algorithm>
#include "lab.h"

#define STRUCT_SIZE 53
#define ll (long long) 

void AddItem() {
	FILE* in = nullptr;
	fopen_s(&in, "output.bin", "r+b");

	int scan_count;
	fread(&scan_count, sizeof(scan_count), 1, in);
	std::cout << "Количество записей: " << scan_count << std::endl;

	std::vector<scan_info> scans;

	for (int i = 0; i < scan_count; i++) // сдвигаем старые элементы
	{
		scan_info newScan;
		fread(newScan.model, sizeof(newScan.model[0]), 25, in);
		std::cout << newScan.model << std::endl;
		fread(&newScan.price, sizeof(newScan.price), 1, in);
		std::cout << newScan.price << std::endl;
		fread(&newScan.x_size, sizeof(newScan.x_size), 1, in);
		std::cout << newScan.x_size << std::endl;
		fread(&newScan.y_size, sizeof(newScan.y_size), 1, in);
		std::cout << newScan.y_size << std::endl;
		fread(&newScan.optr, sizeof(newScan.optr), 1, in);
		std::cout << newScan.optr << std::endl;
		fread(&newScan.grey, sizeof(newScan.grey), 1, in);
		std::cout << newScan.grey << std::endl;
		scans.push_back(newScan);
	}
	fclose(in);
	std::reverse(scans.begin(), scans.end());

	// добавляем новый элемент
	scan_info newScan;
	std::cout << "Введите название модели: ";
	std::cin >> newScan.model;
	std::cout << "Введите стоимость: ";
	std::cin >> newScan.price;
	std::cout << "Введите длину и ширину модели: ";
	std::cin >> newScan.x_size >> newScan.y_size;
	std::cout << "Введите разрешение модели: ";
	std::cin >> newScan.optr;
	std::cout << "Введите число градаций серого: ";
	std::cin >> newScan.grey;
	scans.push_back(newScan);

	// вводим их в файл
	FILE* out;
	fopen_s(&out, "output.bin", "r+b");

	scan_count++;
	fseek(out, 0, SEEK_SET);
	fwrite(&scan_count, sizeof(scan_count), 1, out);
	for (int i = scan_count; i > 0; i--)
	{
		fwrite(scans[i - 1].model, sizeof(scans[i - 1].model[0]), 25, out);
		fwrite(&scans[i - 1].price, sizeof(scans[i - 1].price), 1, out);
		fwrite(&scans[i - 1].x_size, sizeof(scans[i - 1].x_size), 1, out);
		fwrite(&scans[i - 1].y_size, sizeof(scans[i - 1].y_size), 1, out);
		fwrite(&scans[i - 1].optr, sizeof(scans[i - 1].optr), 1, out);
		fwrite(&scans[i - 1].grey, sizeof(scans[i - 1].grey), 1, out);
	}
	fclose(out);
}

void CreateFile()
{
	FILE* out;
	fopen_s(&out, "output.bin", "r+b");
	int scan_count = 1;
	fwrite(&scan_count, sizeof(scan_count), 1, out);

	scan_info newScan;
	std::cout << "Введите название модели: ";
	std::cin >> newScan.model;
	std::cout << "Введите стоимость: ";
	std::cin >> newScan.price;
	std::cout << "Введите длину и ширину модели: ";
	std::cin >> newScan.x_size >> newScan.y_size;
	std::cout << "Введите разрешение модели: ";
	std::cin >> newScan.optr;
	std::cout << "Введите число градаций серого: ";
	std::cin >> newScan.grey;
	fwrite(newScan.model, sizeof(newScan.model[0]), 25, out);
	fwrite(&newScan.price, sizeof(newScan.price), 1, out);
	fwrite(&newScan.x_size, sizeof(newScan.x_size), 1, out);
	fwrite(&newScan.y_size, sizeof(newScan.y_size), 1, out);
	fwrite(&newScan.optr, sizeof(newScan.optr), 1, out);
	fwrite(&newScan.grey, sizeof(newScan.grey), 1, out);

	fclose(out);
}
