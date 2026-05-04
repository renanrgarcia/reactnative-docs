import { deliveryApi } from "../api/delivery-api";

interface GetProductsParams {
  page: number;
  perPage: number;
}

export const getProducts = async (params: GetProductsParams) => {
  const { data } = await deliveryApi.get("products/paginated", { params });
  return data;
};