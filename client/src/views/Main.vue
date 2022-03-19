<template>
<div class="main">
    <div class="main__body">
    <div class="main__header">
      <q-title> Questions </q-title>
      <essential-button>
        <template #label>
          <router-link :to="{name: 'ask-question'}">
            Ask a Question 
          </router-link>
        </template>
      </essential-button>
    </div>
    <div class="main__tabs">
      <tabs-component
        :tabs="tabs"
        :active-tab="activeTab"
        @apply:tab="handleTab"
      />
    </div>

    <div class="main__content">
      <question v-for="item in 10" :key="item"/>
    </div>
  </div>
    <right-sidebar>
    <template #content>
      <div class="main__sidebar">
        <following-tags-block class="main__sidebar-block"/>
        <ignored-tags-block class="main__sidebar-block"/>
      </div>
    </template>
  </right-sidebar>
</div>
</template>

<script>
import QTitle from "@/components/QTitle";
import TabsComponent from "@/components/Tabs";
import EssentialButton from "@/components/EssentialButton";
import Question from "@/components/Question";
import RightSidebar from "@/components/RightSidebar"
import FollowingTagsBlock from "@/components/FollowingTagsBlock"
import IgnoredTagsBlock from "@/components/IgnoredTagsBlock"

export default {
  name: "Main",
  components: {
    QTitle,
    TabsComponent,
    EssentialButton,
    Question,
    RightSidebar,
    FollowingTagsBlock,
    IgnoredTagsBlock
  },
};
</script>

<script setup>
const tabs = ["Interesting", "Popular", "During the week", "During the month"];
import { ref } from "vue";

const activeTab = ref(tabs[1]);

const handleTab = (_tab) => {
  activeTab.value = _tab;
};
</script>

<style scoped lang="scss">
.main {
  display: flex;
  &__body {
    flex-grow: 1;
  }
  &__header {
    display: flex;
    justify-content: space-between;
    margin-left: 10px;
  }
  &__tabs {
    display: flex;
    justify-content:flex-end;
    margin-top: 2rem;
  }
  &__content {
    margin-top: 1rem;
  }
  &__sidebar {
    padding: 0 0 0 10px;
  }
  &__sidebar-block {
    margin-bottom: 1rem;
  }
}
</style>
