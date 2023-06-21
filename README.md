# Проект “Поезд”

# Техническое задание

## Назначение разработки
Поезд - это игра по изучению языка в игровой форме, и развития памяти пользователя, а также развития навыков чтения и произношения. Игра рассчитана на одного игрока с возможностью сохранять результаты своей игры и побивать чужие рекорды. В игре доступны три языка: осетинский, грузинский и армянский, а также три уровня сложности.
 На экране появляется меню игры, где можно авторизоваться (зарегистрироваться или войти), выбрать изучаемый язык, тематику картинок, посмотреть рейтинг и прочитать правила. После авторизации, выбора языка и тематики пользователь может перейти к самой игре. В данной игре доступны два режима: "Учить слова" и "Играть". Чтобы перейти к режиму "Играть", нужно пройти режим "Учить слова". 
Задача игрока заключается в следующем:

1 режим: На экране появляется слово на русском языке с картинкой и слово на выбранном языке с соответствующей картинкой. При нажатии на картинку пользователь может услышать правильное произношение слова. Рекомендуется прочитать слово самому, чтобы лучше запомнить его для использования в следующем режиме. 

2 режим: На экране выезжает поезд с вагонами, каждый из которых подписан на выбранном ранее языке из трех предложенных. В первом уровне у нас 8 вагонов, во втором - 12, в третьем - 19. В каждом уровне на экране разбросаны картинки-образы слов в соответствии со словами на вагонах. При нажатии на картинку-образ слова происходит ее озвучивание на выбранном языке. Задача игрока заключается в перетаскивании картинок-образов слов в вагоны. Поезд скрывается в тоннеле. Если в туннель заезжает не загруженный вагон, то уровень проигран. За каждый правильно загруженный вагон пользователю начисляются 10 баллов, а за неправильную загрузку отнимаются 10 баллов. При идеальном прохождении уровня пользователю начисляются дополнительные баллы (+100 баллов). Попытка поместить картинку в неправильный вагон приводит к потере жизни. В каждом уровне дается по 5 жизней. Если пользователь потеряет все жизни, уровень будет проигран, и у него будут отняты баллы (-100 баллов).

## Функционал
 - Создание меню игры. На отдельной форме находятся 6 кнопок:
         1. Играть (запускает первый режим игры)
         2. Авторизация (открывает форму в которой пользователь может зарегистрироваться или войти,если играет не в первый раз)
         3. Язык (выбор языка из 3 предложенных)
         4. Тематика (выбор тематики картинок/слов из 5 предложенных(можно выбрать 1, несколько или все(в этом случае слова будут выбираться рандомно)))
         5. Рейтинг (рейтинг всех игроков отсортированный по убыванию баллов)
- Создание формы с авторизацией пользователя (пользователь либо вводит свой логин и вводит пароль, если играет не в первый раз и хочет просто войти, либо регистрируется)
- Создание формы для выбора языка (3 кнопки: осетинский язык, грузинский язык, армянский язык)
- Создание формы для выбора тематики слов(5 кнопок: Дом, Домашние животные, Дикие животные, Овощи, фрукты и ягоды, Члены семьи и профессии)
- Создание формы для правил 
- Создание формы для просмотра рейтинга игроков 
- Создание формы для режима “Учить слова” 
- Создание формы для режима “Играть”
- Создание 3 уровней сложности в режиме “Играть”:
- По игровой форме передвигаются картинки вагонов, подписанные на выбранном пользователем языке. На нижней части формы появляются картинки с изображениями, также подписанные, но уже на русском. При нажатии на данные картинки происходит озвучивание этих слов на изучаемом языке, чтобы игроку было проще найти нужный вагон. Уровни отличаются только количеством вагонов и карточек соответственно: 1 уровень: 8 вагонов и карточек
			2 уровень: 12 вагонов и карточек
			3 уровень: 19 вагонов и карточек
- Создание анимации движущегося поезда с вагонами
- Появление картинок-образов
      Количество картинок зависит от уровня сложности (1 ур. - 5 картинок; 2 ур. - 10 картинок; 3 ур. - 15 картинок)
      Картинки берутся в соответствии со словами на вагонах из папки cards
      Размер картинки 450*450 пикселей
      Картинка в формате JPG

- Перетаскивание картинок
- Проверка на правильность (слово - картинка)
- Проверка на завершение игры (проигрыш или победа)
- Начисление баллов за правильность заполнения вагона +10 за правильно загруженный вагон или - 10, если вагон загружен не верно
- Начисление баллов за правильно пройденную игру(+100) или (-100) за проигрыш
- Подсчёт жизней; -1 жизнь, если неправильно загруженный вагон заехал в тоннель
- Озвучивание образов (при нажатии на картинку-образ происходит ее озвучивание)
- Сортировка картинок по тематике
- Переход на следующий уровень сложности 
## Этапы реализации
### Версия 1.0 (01.05.2022 г.)
- Создание анимации движущегося поезда с вагонами
- Появление картинок-образов
- Количество картинок зависит от уровня сложности (1 ур. - 8 картинок; 2 ур. - 12 картинок; 3 ур. - 19 картинок)
  Картинки берутся в соответствии со словами на вагонах из папки cards
  Размер картинки 450*450 пикселей
  Картинка в формате PNG
- Перетаскивание картинок
- Проверка на правильность (слово - картинка)
- Проверка на завершение игры (проигрыш или победа)
- Подсчёт жизней: -1 жизнь, если неправильно загруженный вагон заехал в тоннель
#### Версия 2.0 (1.06.2023 г.)
 - Создание меню игры. На отдельной форме находятся 6 кнопок:
1. Играть (запускает первый режим игры)
2. Авторизация (открывает форму в которой пользователь может зарегистрироваться или войти,если играет не в первый раз)
3. Язык (выбор языка из 3 предложенных)
4. Тематика (выбор тематики картинок/слов из 5 предложенных(можно выбрать 1, несколько или все(в этом случае слова будут выбираться рандомно)))
5. Рейтинг (рейтинг всех игроков отсортированный по убыванию баллов)
- Создание формы с авторизацией пользователя (пользователь либо вводит свой логин и вводит пароль, если играет не в первый раз и хочет просто войти, либо регистрируется)
- Создание формы для выбора языка (3 кнопки: осетинский язык, грузинский язык, армянский язык)
- Создание формы для выбора тематики слов(5 кнопок: Дом, Домашние животные, Дикие животные, Овощи, фрукты и ягоды, Члены семьи и профессии)
- Создание формы для правил 
- Создание формы для просмотра рейтинга игроков 
- Создание формы для режима “Учить слова” 
- Создание формы для режима “Играть”


#### Версия 3.0 (20.06.2023 г.)
- Начисление баллов за правильно пройденную игру(+100) или (-100) за проигрыш
- Подсчёт жизней; -1 жизнь, если неправильно загруженный вагон заехал в тоннель
- Озвучивание образов (при нажатии на картинку-образ происходит ее озвучивание)

Ссылка на текст курсовой работы: https://docs.google.com/document/d/1G_McM0wIUBJ3aNQyFXb0Xk3TcEo28qke1N05QI68kOA/edit?usp=sharing 

Ссылка на презентацию курсовой работы: https://docs.google.com/presentation/d/1Mc-72WotIeDzLkksBb6EGWdEFHUbJaZM5IIv-eg6AAQ/edit?usp=sharing
