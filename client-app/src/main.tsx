import React from 'react'
import ReactDOM from 'react-dom/client'
import { createBrowserHistory } from 'history';

// import {
//   createBrowserRouter,
//   RouterProvider,
//   Route,
// } from "react-router-dom";
import App from './app/App'
import './app/index.css'
import { Router } from 'react-router-dom';


// const router = createBrowserRouter([
//   {
//     path: "/",
//     element: <div>Hello world!</div>,
//   },
// ]);

export const history = createBrowserHistory();

ReactDOM.createRoot(document.getElementById('root') as HTMLElement).render(
  <Router history={history}>
    <App />
  </Router>

)
