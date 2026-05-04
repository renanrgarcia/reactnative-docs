import axios from "axios";
import { Platform } from "react-native";

export const baseURL = Platform.select({
  android: "http://localhost:3001",
  ios: "http://10.0.2.2:3001"
});

export const deliveryApi = axios.create({
  baseURL
});