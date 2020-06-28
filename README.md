# KW_GuideBook

- 광운대학교가 처음인 사람들을 위해 광운대학교 건물 사진을 찍고 입력하면 
  해당 건물에 대한 정보 (진행중인 강의, 연구실, 지도 기능 등) 를 제공하는 프로그램
- 광운대학교 2020년 1학기 응용소프트웨어실습
- 팀원 : 권나성, 김소민, 심다혜, 이원빈

## 시연영상

[![Video Label](./KWGuideImg/main_image.PNG)](https://www.youtube.com/watch?v=wzlhau-rK7Q)

## 라이브러리 설치

### anaconda prompt창에서 아래 라이브러리를 설치해주세요.

- pip install PyQt5
- pip install tensorflow
- pip install keras
- pip install numpy

## 실행 파일

- KW_Guidebook_UI 파일과 CNN 폴더에 있는 python_CNN_Server 파일을 실행해주세요.

## 파일 설명

### CNN 폴더

- KWGuideRE : 수집한 건물 이미지 데이터셋을 증식하고, 전처리 후 CNN 모델을 생성한 파일입니다.
- pyhton_CNN_Server : C# 프로그램과 소켓통신을 하기 위한 파일입니다.

### KW_Guidebook_UI

- winform으로 구성된 C# 프로그램입니다.

### KW_information

- 광운대학교 건물 정보를 저장한 엑셀 파일입니다.

### KWGuideImg

- CNN 모델의 train/test 데이터셋입니다.
