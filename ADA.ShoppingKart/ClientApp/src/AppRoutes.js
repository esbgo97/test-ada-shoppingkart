import { Home } from "./pages/auth/Home";
import { Login } from "./pages/auth/login";
import { Register } from "./pages/auth/register";
import { ProductList } from "./pages/main/ProductList";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/login',
    element: <Login />
  },
  {
    path: '/register',
    element: <Register />
    },
  {
      path: '/products',
      element: <ProductList />
    }
];

export default AppRoutes;
