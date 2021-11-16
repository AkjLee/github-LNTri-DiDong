import "package:flutter/material.dart";
import 'package:flutter_news/services/implement/article_services.dart';
import 'package:flutter_news/ui/news_screen.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter News',
      debugShowCheckedModeBanner: false,
      theme: ThemeData(
        backgroundColor: Color(0xFFf2f2f2),
        primaryColor: Color(0xFF3DE400),
        buttonTheme: ButtonThemeData(
          buttonColor: Color(0xFF0E5626),
        ),
      ),
      home: NewScreen(articleApi: ArticleServices()),
    );
  }
}
