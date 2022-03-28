<template>
  <div class="container">
    <left-side-bar v-if="isShowSidebar">
      <template #content>
        <div class="container__links">
        <router-link class="sidebar-link" exact-active-class="sidebar-link--active" to="/home">Main</router-link>
        <router-link class="sidebar-link" active-class="sidebar-link--active" to="questions">Questions</router-link>
        <router-link class="sidebar-link" active-class="sidebar-link--active" to="tags">Tags</router-link>
        <router-link class="sidebar-link" active-class="sidebar-link--active" to="users">Users</router-link>
        </div>
      </template>
    </left-side-bar>
    <div class="container__page">
      <router-view/>
    </div>
  </div>
</template>

<script>
import LeftSideBar from '../components/LeftSideBar.vue'
export default {
  components: { LeftSideBar },
  name: "Home",
  computed: { 
    isShowSidebar() {
      const state = this.$route?.meta?.sidebar;
      if(state !== undefined) {
        return state
      }
      return true;
    }
  }
}
</script>

<style scoped lang="scss">
.container {
  max-width: 1264px;
  margin: 0 auto;
  height: 100%;
  display: flex;
  &__links {
    position: sticky;
    top: 80px;
  }
  &__page {
    padding: 10px 0;
    padding-top: 30px;
    width: 100%;
  }
}
.sidebar-link {
  text-decoration: none;
  color: var(--black200);
  width: 100%;
  padding: 10px 5px;
  display: flex;
  justify-content: space-between;
  position: relative;
  &:hover {
    color: var(--black400);
  }
  &--active {
    background-color: var(--black25);
    &::after {
      content: "";
      height: 100%;
      display: block;
      width: 3px;
      background-color: hsl(26,90,55);
      position: absolute;
      right: -1px;
      top: 0;
    }
  }
}
</style>
