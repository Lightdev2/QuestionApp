<template>
<div class="users">
  <q-title class="users__title">
    Users
  </q-title>
  <div class="users__tools">
    <search-input placeholder="Filter by user" class="users__input"/>
    <tabs-component :tabs="tabs" :active-tab="activeTab" class="users__tabs"/>
  </div>
  <div class="users__content">
    <div v-for="i in 36" :key="i" class="users__user">
      <div class="users__avatar">

      </div>
      <div class="users__user-info">
        <span class="users__name">Crazy Elf</span>
        <span class="users__home">Moskva, Москва, Россия</span>
        <span class="users__rep">999</span>
      </div>
    </div>
  </div>
  <div class="users__pagination">
    <pagination-component :count="pagesCount" :current="curPage" @next="handleNext"/>
  </div>
</div>
</template>

<script>
import QTitle from "@/components/QTitle"
import SearchInput from "../components/SearchInput.vue"
import TabsComponent from "@/components/TabsComponent"
import PaginationComponent from "@/components/PaginationComponent"
export default {
  name: "Users",
  components: {
    QTitle,
    SearchInput,
    TabsComponent,
    PaginationComponent
}
}
</script>

<script setup>
import {ref} from "vue"
const tabs = ['Reputation', 'New', 'Moderators', 'Editors']
const activeTab = tabs[0];
const curPage = ref(1);
const pagesCount = ref(100);
const handleNext = (_val) => {
  curPage.value = _val;
}
</script>

<style scoped lang="scss">
.users {
  margin-left: 10px;
  &__title {
    margin-bottom: 1rem;
  }
  &__input {
    margin-bottom: 1rem;
  }
  &__tabs {
    margin-bottom: 1rem;
  }
  &__tools {
    display: flex;
    justify-content: space-between;
    margin-right: 10px;
    flex-wrap: wrap;
  }
  &__content {
    display: flex;
    flex-wrap: wrap;
    margin-top: 2rem;
  }
  &__user {
    flex-grow: 1;
    margin-right: 10px;
    display: flex;
  }
  &__user-info {
    display: flex;
    flex-direction: column;
  }
  &__name {
    color: var(--blue600);
  }
  &__home {
    color: var(--black400);
  }
  &__rep {
    color: var(--black700);
  }
  &__avatar {
    width: 50px;
    height: 50px;
    background: #ffff;
    margin-right: 5px;
    margin-bottom: 1rem;
  }
  &__pagination {
    display: flex;
    justify-content: flex-end;
    margin-right: 10px;
    margin-bottom: 1rem;
  }
}
</style>