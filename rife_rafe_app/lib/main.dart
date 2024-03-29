import 'package:flutter/material.dart';
import 'package:rife_rafe_app/routes.dart';
import 'package:rife_rafe_app/screens/profile/profile_screen.dart';
import 'package:rife_rafe_app/screens/splash/splash_screen.dart';
import 'package:rife_rafe_app/theme.dart';

void main() {
  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Riferafe',
      theme: theme(),
      // home: SplashScreen(),
      // We use routeName so that we dont need to remember the name
      initialRoute: SplashScreen.routeName,
      routes: routes,
    );
  }
}
