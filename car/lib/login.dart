import 'package:car/screens/available/available_car_screen.dart';
import 'package:flutter/material.dart';

class LoginSceen extends StatefulWidget {
  LoginSceen({Key? key}) : super(key: key);

  @override
  _LoginSceenState createState() => _LoginSceenState();
}

class _LoginSceenState extends State<LoginSceen> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SizedBox(
        width: MediaQuery.of(context).size.width * 0.8,
        height: MediaQuery.of(context).size.height * 0.6,
        child: Column(children: [
          TextField(
            decoration: InputDecoration(hintText: 'Введите логин'),
          ),
          SizedBox(
            height: 15.0,
          ),
          TextField(
            decoration: InputDecoration(hintText: 'Введите пароль'),
          ),
          TextButton(
              onPressed: () {
                Navigator.of(context).push(MaterialPageRoute(
                    builder: (BuildContext context) => AvailableCarScreen()));
              },
              child: Text("Войти"))
        ]),
      ),
    );
  }
}
