import 'base_provider.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';

class AuthProvider extends Provider {
  AuthProvider() {
    localPath = "/auth";
  }

  Future<List<dynamic>> login() async {
    var url = Uri.parse(baseUrl + localPath);
    http.Response response = await http.get(url);
    List<dynamic> _res = [];
    return _res;
    /*List<Breed> breeds = [];

    if (response.statusCode == 200) {
      Map mapData = await json.decode(response.body);
      var data = mapData["message"];
      for (String key in data.keys) {
        if (key != "") {
          Breed b = Breed(breed: key);
          breeds.add(b);
        }
      }
    }

    return breeds;*/
  }
}
