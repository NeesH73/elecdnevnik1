-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Мар 26 2024 г., 17:06
-- Версия сервера: 5.7.24
-- Версия PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `elecdnev`
--

-- --------------------------------------------------------

--
-- Структура таблицы `admin`
--

CREATE TABLE `admin` (
  `id` int(11) UNSIGNED NOT NULL,
  `login` varchar(100) NOT NULL,
  `pass` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `admin`
--

INSERT INTO `admin` (`id`, `login`, `pass`) VALUES
(1, 'admin', '123');

-- --------------------------------------------------------

--
-- Структура таблицы `exam`
--

CREATE TABLE `exam` (
  `id` int(10) UNSIGNED NOT NULL,
  `login` varchar(50) NOT NULL,
  `groupNumb` varchar(10) NOT NULL,
  `fullName` varchar(50) NOT NULL,
  `subject` varchar(50) NOT NULL,
  `date` date DEFAULT NULL,
  `examType` varchar(50) NOT NULL,
  `grade` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `exam`
--

INSERT INTO `exam` (`id`, `login`, `groupNumb`, `fullName`, `subject`, `date`, `examType`, `grade`) VALUES
(1, 'user', '09-322', 'ivan', 'matan', NULL, 'Экзамен', '100'),
(2, 'user', '09-322', 'ivan', 'english', NULL, 'Зачет', 'Зачёт');

-- --------------------------------------------------------

--
-- Структура таблицы `friday`
--

CREATE TABLE `friday` (
  `id` int(10) UNSIGNED NOT NULL,
  `groupNumb` varchar(50) NOT NULL,
  `time` varchar(20) NOT NULL,
  `subject` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `friday`
--

INSERT INTO `friday` (`id`, `groupNumb`, `time`, `subject`) VALUES
(1, '09-322', '10:10-11:40', 'Физическая культура'),
(2, '09-322', '12:10-13:40', 'История России');

-- --------------------------------------------------------

--
-- Структура таблицы `monday`
--

CREATE TABLE `monday` (
  `id` int(10) UNSIGNED NOT NULL,
  `groupNumb` varchar(50) NOT NULL,
  `time` varchar(20) NOT NULL,
  `subject` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `monday`
--

INSERT INTO `monday` (`id`, `groupNumb`, `time`, `subject`) VALUES
(1, '09-322', '10:10-11:40', 'Иностранный язык'),
(2, '09-322', '10:10-11:40', 'Иностранный язык'),
(3, '09-322', '12:10-13:40', 'Математический анализ'),
(4, '09-322', '13:50-15:20', 'История России');

-- --------------------------------------------------------

--
-- Структура таблицы `saturday`
--

CREATE TABLE `saturday` (
  `id` int(11) UNSIGNED NOT NULL,
  `groupNumb` varchar(50) NOT NULL,
  `time` varchar(32) NOT NULL,
  `subject` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `saturday`
--

INSERT INTO `saturday` (`id`, `groupNumb`, `time`, `subject`) VALUES
(1, '09-322', '12:10-13:40', 'Ознакомительная практика'),
(2, '09-322', '13:50-15:20', 'Разработка приложений на C#');

-- --------------------------------------------------------

--
-- Структура таблицы `thursday`
--

CREATE TABLE `thursday` (
  `id` int(10) UNSIGNED NOT NULL,
  `groupNumb` varchar(50) NOT NULL,
  `time` varchar(20) NOT NULL,
  `subject` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `thursday`
--

INSERT INTO `thursday` (`id`, `groupNumb`, `time`, `subject`) VALUES
(1, '09-322', '8:30-10:00', 'Алгебра и геометрия'),
(2, '09-322', '10:10-11:40', 'Математический анализ'),
(3, '09-322', '12:10-13:40', 'Алгебра и геометрия');

-- --------------------------------------------------------

--
-- Структура таблицы `tuesday`
--

CREATE TABLE `tuesday` (
  `id` int(10) UNSIGNED NOT NULL,
  `groupNumb` varchar(50) NOT NULL,
  `time` varchar(20) NOT NULL,
  `subject` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `tuesday`
--

INSERT INTO `tuesday` (`id`, `groupNumb`, `time`, `subject`) VALUES
(1, '09-322', '10:10-11:40', 'Физическая культура'),
(2, '09-322', '12:10-13:40', 'Русский язык'),
(3, '09-322', '13:50-15:20', 'Русский язык');

-- --------------------------------------------------------

--
-- Структура таблицы `user`
--

CREATE TABLE `user` (
  `id` int(11) UNSIGNED NOT NULL,
  `login` varchar(100) NOT NULL,
  `pass` varchar(32) NOT NULL,
  `groupNumb` varchar(50) NOT NULL,
  `fullName` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `user`
--

INSERT INTO `user` (`id`, `login`, `pass`, `groupNumb`, `fullName`) VALUES
(1, 'user', '123', '09-322', 'ivanov ivan ivanovich'),
(3, 'user1', '123', '09-322', 'Petrov Petr Petrovich');

-- --------------------------------------------------------

--
-- Структура таблицы `wednesday`
--

CREATE TABLE `wednesday` (
  `id` int(10) UNSIGNED NOT NULL,
  `groupNumb` varchar(50) NOT NULL,
  `time` varchar(20) NOT NULL,
  `subject` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `wednesday`
--

INSERT INTO `wednesday` (`id`, `groupNumb`, `time`, `subject`) VALUES
(1, '09-322', '10:10-11:40', 'Противодействия коррупции'),
(2, '09-322', '12:10-13:40', 'Противодействия коррупции'),
(3, '09-322', '15:50-17:20', 'Математический анализ');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `admin`
--
ALTER TABLE `admin`
  ADD UNIQUE KEY `id` (`id`);

--
-- Индексы таблицы `exam`
--
ALTER TABLE `exam`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `friday`
--
ALTER TABLE `friday`
  ADD UNIQUE KEY `id` (`id`);

--
-- Индексы таблицы `monday`
--
ALTER TABLE `monday`
  ADD UNIQUE KEY `id` (`id`);

--
-- Индексы таблицы `saturday`
--
ALTER TABLE `saturday`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `thursday`
--
ALTER TABLE `thursday`
  ADD UNIQUE KEY `id` (`id`);

--
-- Индексы таблицы `tuesday`
--
ALTER TABLE `tuesday`
  ADD UNIQUE KEY `id` (`id`);

--
-- Индексы таблицы `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `login` (`login`);

--
-- Индексы таблицы `wednesday`
--
ALTER TABLE `wednesday`
  ADD UNIQUE KEY `id` (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `admin`
--
ALTER TABLE `admin`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `exam`
--
ALTER TABLE `exam`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=81;

--
-- AUTO_INCREMENT для таблицы `friday`
--
ALTER TABLE `friday`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `monday`
--
ALTER TABLE `monday`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `saturday`
--
ALTER TABLE `saturday`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `thursday`
--
ALTER TABLE `thursday`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `tuesday`
--
ALTER TABLE `tuesday`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `wednesday`
--
ALTER TABLE `wednesday`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
