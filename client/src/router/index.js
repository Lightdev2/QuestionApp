import { createRouter, createWebHashHistory } from 'vue-router'
import Home from '../views/Home.vue'
import SignIn from "../views/SignIn.vue";
import SignUp from "../views/SignUp.vue";
import Questions from "../views/Questions.vue";
import Users from "../views/Users.vue";
import Tags from "../views/Tags.vue";
import Main from "../views/Main.vue";

const routes = [
  {
    path: '/',
    name: 'main',
    component: Home,
    children: [
      {
        path: '/',
        component: Main
      },
      {
        path: "questions",
        name: "questions",
        component: Questions,
      },
      {
        path: "tags",
        name: "tags",
        component: Tags
      },
      {
        path: "users",
        name: "users",
        component: Users
      }
    ]
  },
  {
    path: '/sign-in',
    name: 'sign-in',
    component: SignIn,
  },
  {
    path: '/sign-up',
    name: 'sign-up',
    component: SignUp
  }
]

const router = createRouter({
  history: createWebHashHistory(),
  routes
})

export default router
