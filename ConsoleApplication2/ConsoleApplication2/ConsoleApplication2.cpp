#include "stdafx.h"

#include <stdio.h>
#include <windows.h>
#include <time.h>
#include <string>
#include <iostream>
#include <fstream>

using namespace std;

#pragma pack(2)

//��������� ����� BMP 
typedef struct tBITMAPFILEHEADER
{
	WORD bfType;
	DWORD bfSize;
	WORD bfReserved1;
	WORD bfReserved2;
	DWORD bfOffBits;
}sFileHead;

//��������� BitMap's
typedef struct tBITMAPINFOHEADER
{
	DWORD biSize;
	LONG biWidth;
	LONG biHeight;
	WORD biPlanes;
	WORD biBitCount;
	DWORD biCompression;
	DWORD biSizeImage;
	LONG biXPelsPerMeter;
	LONG biYPelsPerMeter;
	DWORD biClrUsed;
	DWORD biClrImportant;
}sInfoHead;

sFileHead FileHead;
sInfoHead InfoHead;

//�������
struct Color
{
	BYTE red;
	BYTE green;
	BYTE blue;
};

//������ 1-�� �������
int pixel_size = sizeof(Color);


//1 - BMP, 2 - CMP
int img_type = 0;

//�������� �����������
Color *src_image = 0;
//�������������� �����������
Color *dst_image = 0;

//������ �����������
int width = 0;
int height = 0;

//������� ��������� BMP �����
void ShowBMPHeaders(tBITMAPFILEHEADER fh, tBITMAPINFOHEADER ih)
{
	cout << "Type: " << (CHAR)fh.bfType << endl;
	cout << "Size: " << fh.bfSize << endl;
	cout << "Shift of bits: " << fh.bfOffBits << endl;
	cout << "Width: " << ih.biWidth << endl;
	cout << "Height: " << ih.biHeight << endl;
	cout << "Planes: " << ih.biPlanes << endl;
	cout << "BitCount: " << ih.biBitCount << endl;
	cout << "Compression: " << ih.biCompression << endl;
}

//������� ��� �������� �����������
bool OpenImage(string path)
{
	ifstream img_file;
	Color temp;
	char buf[3];

	//������� ���� �� ������
	img_file.open(path.c_str(), ios::in | ios::binary);
	if (!img_file)
	{
		cout << "File isn`t open!" << endl;
		return false;
	}

	//������� ��������� BMP
	img_file.read((char*)&FileHead, sizeof(FileHead));
	img_file.read((char*)&InfoHead, sizeof(InfoHead));

	img_type = 1;
	ShowBMPHeaders(FileHead, InfoHead);
	//��������� ����� � ������ �����������
	width = InfoHead.biWidth;
	height = InfoHead.biHeight;


	//�������� ����� ��� �����������
	src_image = new Color[width*height];

	int i, j;
	for (i = 0; i < height; i++)
	{
		for (j = 0; j < width; j++)
		{
			img_file.read((char*)&temp, pixel_size);
			src_image[i*width + j] = temp;
		}
		//�������� ���� ������������ ��� ������������ �� �������� �����
		img_file.read((char*)buf, j % 4);
	}
	img_file.close();

	return true;
}

//������� ��� ���������� �����������
bool SaveImage(string path)
{
	ofstream img_file;
	char buf[3];

	//������� ���� �� ������
	img_file.open(path.c_str(), ios::out | ios::binary);
	if (!img_file)
	{
		return false;
	}

	img_file.write((char*)&FileHead, sizeof(FileHead));
	img_file.write((char*)&InfoHead, sizeof(InfoHead));

	//����������� �� ��������� � �������������� �����������
	if (dst_image == 0)
	{
		dst_image = new Color[width*height];
		memcpy(dst_image, src_image, width*height * sizeof(Color));
	}

	//�������� ����
	int i, j;
	for (i = 0; i < height; i++)
	{
		for (j = 0; j < width; j++)
		{
			img_file.write((char*)&dst_image[i*width + j], pixel_size);
		}
		img_file.write((char*)buf, j % 4);
	}
	img_file.close();

	return true;
}

//����������� ���������� ��������������� ����������� � ���������
void CopyDstToSrc()
{
	if (dst_image != 0)
	{
		memcpy(src_image, dst_image, width*height * sizeof(Color));
	}
}

//���������� ����������� � �������� ����� �����������
void AddNoise(double probability)
{
	int size = width * height;
	int count = (int)(size * probability) / 100;
	int x, y;
	long pos;
	for (int i = 0; i < count; i++)
	{
		x = rand() % width;
		y = rand() % height;
		pos = y * width + x;
		src_image[pos].blue = 0 + rand() % 255;
		src_image[pos].green = 0 + rand() % 255;
		src_image[pos].red = 0 + rand() % 255;
	}
	cout << "Point was added: " << count << endl;
}

void RemoveNoise() 
{
	int size = width * height;
	int x, y;
	long pos;
	double mask[3][3];
	double median;

	for (int i = 0; i < size; i++)
	{
		x = rand() % width;
		y = rand() % height;
		pos = y * width + x;
		mask[0][0] = (0.3 * src_image[pos].red) + (0.59 * src_image[pos].green) + (0.11 * src_image[pos].blue);
		mask[0][1] = (0.3 * src_image[pos].red) + (0.59 * src_image[pos].green) + (0.11 * src_image[pos].blue);
		mask[0][2] = (0.3 * src_image[pos].red) + (0.59 * src_image[pos].green) + (0.11 * src_image[pos].blue);
		mask[1][0] = (0.3 * src_image[pos].red) + (0.59 * src_image[pos].green) + (0.11 * src_image[pos].blue);
		mask[1][1] = (0.3 * src_image[pos].red) + (0.59 * src_image[pos].green) + (0.11 * src_image[pos].blue);
		mask[1][2] = (0.3 * src_image[pos].red) + (0.59 * src_image[pos].green) + (0.11 * src_image[pos].blue);
		mask[2][0] = (0.3 * src_image[pos].red) + (0.59 * src_image[pos].green) + (0.11 * src_image[pos].blue);
		mask[2][1] = (0.3 * src_image[pos].red) + (0.59 * src_image[pos].green) + (0.11 * src_image[pos].blue);
		mask[2][2] = (0.3 * src_image[pos].red) + (0.59 * src_image[pos].green) + (0.11 * src_image[pos].blue);

		median = (mask[0][0] + mask[0][1] + mask[0][2] + mask[1][0] + mask[1][2] + mask[2][0] + mask[2][1] + mask[2][2]) / 8;

		if (abs(mask[1][1] - median) > 10) {
			src_image[pos].blue = median / mask[1][1];
			src_image[pos].green = median / mask[1][1];
			src_image[pos].red = median / mask[1][1];
		}

		
	}
	cout << "Point was deleted: " << size << endl;
}

//���������� ������� ����������� � ������� ������ ������������ ������������
void ShowImage(string path)
{
	ShowBMPHeaders(FileHead, InfoHead);
	system(path.c_str());
}

//������� ���� � �����������
void ReadPath(string &str)
{
	str.clear();
	cout << "Enter path to image" << endl;
	cin >> str;
}



int main(int argc, char* argv[])
{
	int noise = 0;
	srand((unsigned)time(NULL));

	//���� � �������� �����������
	string path_to_image, temp, buf;

	ReadPath(path_to_image);
	OpenImage(path_to_image);
	ShowImage(path_to_image);

	cout << "Enter Noise: ";
	cin >> noise;

	AddNoise(noise);
	RemoveNoise();
	ReadPath(temp);
	SaveImage(temp);
	ShowImage(temp);

	

	//���������� ������ ��������� �����������
	if (src_image != 0)
	{
		delete[] src_image;
	}
	//���������� ������ �������������� �����������
	if (dst_image != 0)
	{
		delete[] dst_image;
	}

	return 0;
}