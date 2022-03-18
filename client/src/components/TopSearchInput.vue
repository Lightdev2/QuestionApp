<template>
  <div class="wrp">
    <div class="search" @click="showDropDown">
      <search-icon class="search__icon search__icon--abs" />
      <input
        class="search__input"
        type="text"
        placeholder="Search"
        @focus="showDropDown"
      />
      <search-icon class="search__icon search__icon--abs search__icon--mobile" />
      <input
        class="search__input search__input--mobile"
        type="text"
        placeholder="Search"
        v-if="isShowMobileInput"
      />
      <div v-if="isShowDropDown" class="search__dropdown">
        <div class="search__dropdown--helpers">
          <div>
            <span class="search__helper-left">[метка] </span>
            <span class="search__helper-right">поиск по метке</span>
          </div>
          <div>
            <span class="search__helper-left">user:1234 </span>
            <span class="search__helper-right">поиск по автору</span>
          </div>
          <div>
            <span class="search__helper-left">"слова в кавычках" </span>
            <span class="search__helper-right">точная фраза</span>
          </div>
          <div>
            <span class="search__helper-left">answers:0 </span>
            <span class="search__helper-right">неотвеченные вопросы</span>
          </div>
          <div>
            <span class="search__helper-left">score:3 </span>
            <span class="search__helper-right">сообщения с рейтингом 3+</span>
          </div>
          <div>
            <span class="search__helper-left">isaccepted:yes </span>
            <span class="search__helper-right">поиск по статусу</span>
          </div>
        </div>
        <div class="search__controls">
          <primary-button>
            <template #label> Задать вопрос </template>
          </primary-button>
          <a class="link" href="#">Справка по поиску</a>
        </div>
      </div>
    </div>
    <button @click="toggleDropDown" class="search__btn">
      <search-icon class="search__icon" />
    </button>
  </div>
</template>

<script>
import SearchIcon from "@/assets/search";
import PrimaryButton from "@/components/PrimaryButton";

export default {
  name: "TopSearchInput",
  components: { SearchIcon, PrimaryButton },
};
</script>

<script setup>
import { ref, onMounted, onUnmounted } from "vue";

const isShowDropDown = ref(false);
const isShowMobileInput = ref(false);
const showDropDown = () => {
  isShowDropDown.value = true;
  isShowMobileInput.value = true;
};
const toggleDropDown = () => {
  isShowDropDown.value = !isShowDropDown.value;
   toggleMobileInput()
};
const closeDropDown = ({ target }) => {
  if (!target.closest(".wrp")) {
    isShowDropDown.value = false;
    isShowMobileInput.value = false;
  }
};
const toggleMobileInput = () => {
  isShowMobileInput.value = !isShowMobileInput.value;
}
const closeDropDownByEsc = ({ code }) => {
  if (code === "Escape") {
    isShowDropDown.value = false;
    isShowMobileInput.value = false;
  }
};
onMounted(() => {
  document.addEventListener("click", closeDropDown);
  document.addEventListener("keydown", closeDropDownByEsc);
});
onUnmounted(() => {
  document.removeEventListener("click", closeDropDown);
  document.removeEventListener("keydown", closeDropDownByEsc);
});
</script>

<style scoped lang="scss">
.search {
  min-height: 50px;
  display: flex;
  align-items: center;
  position: relative;
  flex-grow: 1;
  &__btn {
    background: transparent;
    display: flex;
    align-items: center;
    justify-content: center;
    border: none;
    cursor: pointer;
    height: 50px;
    @media screen and (min-width: 760px) {
      display: none;
    }
    &:hover {
      background-color: var(--black75);
    }
  }

  &__icon {
    width: 20px;
    height: 20px;
    fill: var(--black300);
    &--abs {
      position: absolute;
      left: 5px;
      @media screen and (max-width: 760px) {
        display: none;
      }
    }
  }

  &__input {
    width: 100%;
    background-color: var(--black);
    border: 1px solid var(--black200);
    border-radius: 5px;
    flex-grow: 1;
    color: var(--black700);
    padding: 7.8px 9.1px 7.8px 35px;
    outline: none;
    font-size: 13px;
    &:focus {
      border-color: var(--blue300);
    }
    @media screen and (max-width: 760px) {
      display: none;
    }
    &--mobile {
      display: none;
      @media screen and (max-width: 760px) {
        display: flex;
        position: fixed;
        top: 0;
        right: 0;
        top: 55px;
        z-index: 9999;
      }
    }
  }

  &__dropdown {
    position: absolute;
    background-color: var(--black75);
    width: 100%;
    top: 50px;
    border-radius: 5px;
    padding: 10px;
    box-shadow: var(--bs-light);
    @media screen and (max-width: 760px) {
      position: fixed;
      top: 90px;
      right: 0;
    }
  }

  &__dropdown--helpers {
    display: grid;
    grid-template-columns: repeat(2, 1fr);
    grid-auto-rows: 30px;
  }

  &__helper-left {
    color: var(--black900);
  }

  &__helper-right {
    color: var(--black300);
  }

  &__controls {
    margin-top: 1rem;
    display: flex;
    align-items: center;
    justify-content: space-between;
  }
}
.wrp {
  flex-grow: 1;
  width: 100%;

  @media screen and (max-width: 760px) {
    display: flex;
    justify-content: flex-end;
  }
}
</style>
