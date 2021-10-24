import 'package:flutter/material.dart';
import 'package:rife_rafe_app/size_config.dart';

const kPrimaryColor = Color(0xFFA68524);
const kPrimaryLightColor = Color(0xFFF2CA52);
const kPrimaryGradientColor = LinearGradient(
  begin: Alignment.topLeft,
  end: Alignment.bottomRight,
  colors: [Color(0xFFFFA53E), Color(0xFFFF7643)],
);
const kSecondaryColor = Color(0xFF979797);
const kTextColor = Color(0xFF757575);

const kAnimationDuration = Duration(milliseconds: 200);

final headingStyle = TextStyle(
  fontSize: getProportionateScreenWidth(28),
  fontWeight: FontWeight.bold,
  color: Colors.black,
  height: 1.5,
);

const defaultDuration = Duration(milliseconds: 250);

// Form Error
final RegExp emailValidatorRegExp =
    RegExp(r"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z]+");
const String kEmailNullError = "Porfavor ingrese un email";
const String kInvalidEmailError = "Por favor ingrese un email valido";
const String kPassNullError = "Debes ingresar una contraseña";
const String kShortPassError = "La contraseña es demasiado corta";
const String kMatchPassError = "Contraseñas no coinciden";
const String kNamelNullError = "Porfavor ingresa un nombre";
const String kPhoneNumberNullError = "Por favor ingresa un numero telefonico";
const String kAddressNullError =
    "Porfavor ingresa la dirección de correo electronico";

final otpInputDecoration = InputDecoration(
  contentPadding:
      EdgeInsets.symmetric(vertical: getProportionateScreenWidth(15)),
  border: outlineInputBorder(),
  focusedBorder: outlineInputBorder(),
  enabledBorder: outlineInputBorder(),
);

OutlineInputBorder outlineInputBorder() {
  return OutlineInputBorder(
    borderRadius: BorderRadius.circular(getProportionateScreenWidth(15)),
    borderSide: BorderSide(color: kTextColor),
  );
}
