Python 3 (tags/v3:5c02a39a0b, Oct 14 2019, 23:09:19) [MSC v.1916 32 bit (Intel)] on win32
Type "help", "copyright", "credits" or "license()" for more information.
>>>
#!/usr/bin/python
# -*- coding: utf-8 -*-
# -*- coding: euc-kr -*-
from PIL import Image
import os, glob, numpy as np #이미지 프로세싱
from sklearn.model_selection import train_test_split #train set과 test set으로 분류 

# 데이터셋 저장한 디렉토리
base_dir = './KWGuideImg/dataset/train'
categories=os.listdir(base_dir) #["기념","화도","옥의","비마","새빛","참빛","한울","연구"]
nb_classes=len(categories) #class 개수 설정

from keras.preprocessing.image import ImageDataGenerator

#ImageDataGenerator 클래스 사용하여 이미지 데이터 증식

datagen = ImageDataGenerator(
    rotation_range=40, #이미지 회전 범위
    width_shift_range=0.2, #그림 수평 or 수직으로 랜덤하게 평행이동시키는 범위
    height_shift_range=0.2,
    rescale=1./255, #1/255로 스케일링하여 0~1범위로 변환하여 효과적으로 학습
    shear_range=0.2, #임의 전단 변환
    zoom_range=0.2, #임의 확대/축소 범위
    horizontal_flip=False, #이미지를 50%확률로 수평으로 뒤집음(뒤집으면 자연스럽지 않으므로, False) 
    fill_mode='nearest') #이미지를 회전, 이동하거나 축소할 때 생기는 공간 채움

# 훈련용 80주념기념관 사진 디렉터리
train_ginyeom_dir = './KWGuideImg/dataset/train/gi'

# 훈련용 화도관 사진 디렉터리
train_hwado_dir = './KWGuideImg/dataset/train/hwan'

# 훈련용 새빛관 사진 디렉터리
train_saebit_dir = './KWGuideImg/dataset/train/se'

# 훈련용 비마관 사진 디렉터리
train_bima_dir = './KWGuideImg/dataset/train/bi'

# 훈련용 옥의관 사진 디렉터리
train_oakui_dir = './KWGuideImg/dataset/train/oak'

# 훈련용 한천재 사진 디렉터리
train_hancheon_dir = './KWGuideImg/dataset/train/hanchoen'

# 훈련용 복지관 사진 디렉터리
train_bokji_dir = './KWGuideImg/dataset/train/bok'

# 훈련용 연구관 사진 디렉터리
train_yeonku_dir = './KWGuideImg/dataset/train/yeon'

# 훈련용 참빛관 사진 디렉터리
train_chambit_dir = './KWGuideImg/dataset/train/cham'

# 훈련용 한울관 사진 디렉터리
train_hanoul_dir = './KWGuideImg/dataset/train/hanoul'

# 이미지 전처리 유틸리티 모듈
from keras.preprocessing import image

fnames1 = sorted([os.path.join(train_ginyeom_dir, fname) for fname in os.listdir(train_ginyeom_dir)])
fnames2 = sorted([os.path.join(train_hwado_dir, fname) for fname in os.listdir(train_hwado_dir)])
fnames3 = sorted([os.path.join(train_saebit_dir, fname) for fname in os.listdir(train_saebit_dir)])
fnames4 = sorted([os.path.join(train_bima_dir, fname) for fname in os.listdir(train_bima_dir)])
fnames5 = sorted([os.path.join(train_oakui_dir, fname) for fname in os.listdir(train_oakui_dir)])
fnames6 = sorted([os.path.join(train_chambit_dir, fname) for fname in os.listdir(train_chambit_dir)])
fnames7 = sorted([os.path.join(train_hanoul_dir, fname) for fname in os.listdir(train_hanoul_dir)])

#이미지 데이터 증식 (한번만 수행)

for img_path in fnames1:

    img = image.load_img(img_path, target_size=(150, 150)) # 이미지 읽고 크기 변경

    x = image.img_to_array(img) # (150, 150, 3) 크기의 넘파이 배열

    x = x.reshape((1,) + x.shape) # (1, 150, 150, 3) 크기의 넘파이 배열

    # flow() 메서드로 랜덤하게 변환된 이미지를 배치 단위로 생성하여 폴더에 저장
    i = 0
    for batch in datagen.flow(x, batch_size=1,
                             save_to_dir='./KWGuideImg/dataset/train/gi',save_format='jpg'):
        i += 1
        if i > 10:
            break #이미지 10장 생성

for img_path in fnames2:

    img = image.load_img(img_path, target_size=(150, 150)) # 이미지 읽고 크기 변경

    x = image.img_to_array(img) # (150, 150, 3) 크기의 넘파이 배열

    x = x.reshape((1,) + x.shape) # (1, 150, 150, 3) 크기의 넘파이 배열

    # flow() 메서드로 랜덤하게 변환된 이미지를 배치 단위로 생성하여 폴더에 저장
    i = 0
    for batch in datagen.flow(x, batch_size=1,
                             save_to_dir='./KWGuideImg/dataset/train/hwan',save_format='jpg'):
        i += 1
        if i > 10:
            break #이미지 10장 생성
for img_path in fnames3:

    img = image.load_img(img_path, target_size=(150, 150)) # 이미지 읽고 크기 변경

    x = image.img_to_array(img) # (150, 150, 3) 크기의 넘파이 배열

    x = x.reshape((1,) + x.shape) # (1, 150, 150, 3) 크기의 넘파이 배열

    # flow() 메서드로 랜덤하게 변환된 이미지를 배치 단위로 생성하여 폴더에 저장
    i = 0
    for batch in datagen.flow(x, batch_size=1,
                             save_to_dir='./KWGuideImg/dataset/train/se',save_format='jpg'):
        i += 1
        if i > 10:
            break #이미지 10장 생성
for img_path in fnames4:

    img = image.load_img(img_path, target_size=(150, 150)) # 이미지 읽고 크기 변경

    x = image.img_to_array(img) # (150, 150, 3) 크기의 넘파이 배열

    x = x.reshape((1,) + x.shape) # (1, 150, 150, 3) 크기의 넘파이 배열

    # flow() 메서드로 랜덤하게 변환된 이미지를 배치 단위로 생성하여 폴더에 저장
    i = 0
    for batch in datagen.flow(x, batch_size=1,
                             save_to_dir='./KWGuideImg/dataset/train/bi',save_format='jpg'):
        i += 1
        if i > 10:
            break #이미지 10장 생성
for img_path in fnames5:

    img = image.load_img(img_path, target_size=(150, 150)) # 이미지 읽고 크기 변경

    x = image.img_to_array(img) # (150, 150, 3) 크기의 넘파이 배열

    x = x.reshape((1,) + x.shape) # (1, 150, 150, 3) 크기의 넘파이 배열

    # flow() 메서드로 랜덤하게 변환된 이미지를 배치 단위로 생성하여 폴더에 저장
    i = 0
    for batch in datagen.flow(x, batch_size=1,
                             save_to_dir='./KWGuideImg/dataset/train/oak',save_format='jpg'):
        i += 1
        if i > 10:
            break #이미지 10장 생성
for img_path in fnames6:

    img = image.load_img(img_path, target_size=(150, 150)) # 이미지 읽고 크기 변경

    x = image.img_to_array(img) # (150, 150, 3) 크기의 넘파이 배열

    x = x.reshape((1,) + x.shape) # (1, 150, 150, 3) 크기의 넘파이 배열

    # flow() 메서드로 랜덤하게 변환된 이미지를 배치 단위로 생성하여 폴더에 저장
    i = 0
    for batch in datagen.flow(x, batch_size=1,
                             save_to_dir='./KWGuideImg/dataset/train/cham',save_format='jpg'):
        i += 1
        if i > 10:
            break #이미지 10장 생성

for img_path in fnames7:

    img = image.load_img(img_path, target_size=(150, 150)) # 이미지 읽고 크기 변경

    x = image.img_to_array(img) # (150, 150, 3) 크기의 넘파이 배열

    x = x.reshape((1,) + x.shape) # (1, 150, 150, 3) 크기의 넘파이 배열

    # flow() 메서드로 랜덤하게 변환된 이미지를 배치 단위로 생성하여 폴더에 저장
    i = 0
    for batch in datagen.flow(x, batch_size=1,
                             save_to_dir='./KWGuideImg/dataset/train/hanoul',save_format='jpg'):
        i += 1
        if i > 10:
            break #이미지 10장 생성            

            
image_w = 64
image_h = 64 #크기지정

pixels = image_h * image_w * 3

X = []
y = []

for idx, cat in enumerate(categories):  #각 건물마다
    
    label = [0 for i in range(nb_classes)] #건물 카테고리 개수
    label[idx] = 1

    image_ = base_dir + "/" + cat
    files = glob.glob(image_+"/*.jpg")
    print(cat, " 파일 길이 : ", len(files))
    for i, f in enumerate(files):
        img = Image.open(f)
        img = img.convert("RGB") #RGB로 변환 
        img = img.resize((image_w, image_h)) #크기 (64,64)로 변환
        data = np.asarray(img) #numpy.ndarray()형식으로 변환

        X.append(data) #train image
        y.append(label) #train label 

        if i % 700 == 0:
            print(cat, " : ", f)

X = np.array(X)
y = np.array(y)
#1 0 0 0 0 0 0 이면 기념관
#0 1 0 0 0 0 0이면 화도관


X_train, X_test, y_train, y_test = train_test_split(X, y) #트레인이미지와 테스트이미지 나눔
xy = (X_train, X_test, y_train, y_test)
np.save('dataset_numpy.npy', xy) #("C:/KWGuideImg/dataset/test", xy) 

print("ok", len(y))

#numpy 데이터 불러옴
import os, glob, numpy as np
from keras.models import Sequential
from keras.layers import Conv2D, MaxPooling2D, Dense, Flatten, Dropout
from keras.callbacks import EarlyStopping, ModelCheckpoint
import matplotlib.pyplot as plt
import keras.backend.tensorflow_backend as K
import tensorflow as tf

config =  tf.compat.v1.ConfigProto()
config.gpu_options.allow_growth = True
session = tf.compat.v1.Session(config=config)

X_train, X_test, y_train, y_test = np.load('dataset_numpy.npy',allow_pickle=True)
print(X_train.shape)
print(X_train.shape[0])
print(y_train.shape)

categories=os.listdir(base_dir)
nb_classes = len(categories)

#train/ test분류
X_train = X_train.astype(float) / 255
X_test = X_test.astype(float) / 255
print ("ok")

with K.tf_ops.device('/device:CPU:0'):
    model = Sequential()
    model.add(Conv2D(32, (3,3), padding="same", input_shape=X_train.shape[1:], activation='relu'))
    model.add(MaxPooling2D(pool_size=(2,2)))
    model.add(Dropout(0.25))
    
    model.add(Conv2D(64, (3,3), padding="same", activation='relu'))
    model.add(MaxPooling2D(pool_size=(2,2)))
    model.add(Dropout(0.25))
    
    model.add(Flatten())
    model.add(Dense(256, activation='relu'))
    model.add(Dropout(0.5))
    model.add(Dense(nb_classes, activation='sigmoid'))
    model.compile(loss='categorical_crossentropy', optimizer='adam', metrics=['accuracy'])
    model_dir = './model'
    
    if not os.path.exists(model_dir):
        os.mkdir(model_dir)
    
    model_path = model_dir + '/multi_img_classification.model'
    checkpoint = ModelCheckpoint(filepath=model_path , monitor='val_loss', verbose=1, save_best_only=True)
    early_stopping = EarlyStopping(monitor='val_loss', patience=6)
    
    print("ok")
    
model.summary()

#validation 변경 -> validation_split=0.2
history = model.fit(X_train, y_train, batch_size=32, epochs=10)
#, validation_data=(X_test, y_test), callbacks=[checkpoint, early_stopping]
print("정확도 : %.4f" % (model.evaluate(X_test, y_test)[1]))

#img 하나만 실행

from PIL import Image
import os, glob, numpy as np
from keras.models import load_model

test_img='./KWGuideImg/dataset/test/test_img3.jpg'
img = Image.open(test_img)
img.show() #이미지 출력
img = img.convert("RGB")
img = img.resize((image_w, image_h)) #사이즈 재조정
data = np.asarray(img)

X=np.array(data)

X = X.astype("float") / 256
X = X.reshape(-1, 64, 64,3)

#훈련된 모델을 사용하여 이미지 예측
predictions = model.predict(X)  #X이미지 레이블 예측
predictions[0]
result = np.argmax(predictions[0])    # 예측 값중 가장 높은 신뢰도를 가진 레이블
print('New data category : ',categories[result]) #카테고리중 해당되는 것 반환

test_img='./KWGuideImg/dataset/test/test_img2.jpg'
img = Image.open(test_img)
img.show() #이미지 출력
img = img.convert("RGB")
img = img.resize((image_w, image_h)) #사이즈 재조정
data = np.asarray(img)

X=np.array(data)

X = X.astype("float") / 256
X = X.reshape(-1, 64, 64,3)

#훈련된 모델을 사용하여 이미지 예측
predictions = model.predict(X)  #X이미지 레이블 예측
predictions[0]
result = np.argmax(predictions[0])    # 예측 값중 가장 높은 신뢰도를 가진 레이블
print('New data category : ',categories[result]) #카테고리중 해당되는 것 반환
